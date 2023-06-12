using CloudreveMiddleLayer;
using CloudreveMiddleLayer.DataSet;
using ComponentControls.Forms;
using ComponentControls.Helper.IO;
using ComponentControls.Helper.String;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CloudreveForWindows.Forms
{
    public partial class Login : Form
    {
        DataSetSystemConfig.TBL_ServerInfoDataTable dtDB = new DataSetSystemConfig.TBL_ServerInfoDataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (CloudreveMiddleLayer.Entiry.Login.GetServerInfo(dtDB))
                {
                    int autoLoginRowIndex = -1;
                    for (int i = 0; i < dtDB.Count; i++)
                    {
                        cboDB.Items.Insert(0, dtDB[i].ServerUrl);
                        if (Convert.ToBoolean(dtDB[i].AutoLogin))
                        {
                            autoLoginRowIndex = i;
                        }
                    }
                    if (autoLoginRowIndex != -1)
                    {
                        cboDB.SelectedIndex = 0;
                        txtUserName.Text = dtDB[autoLoginRowIndex].UserName;
                        txtPWD.Text = DecryptAndEncryptionHelper.Decrypto(dtDB[autoLoginRowIndex].Password);
                        Util.GLOBLE_COOKIE = DecryptAndEncryptionHelper.Decrypto(dtDB[autoLoginRowIndex].Cookie);
                        chkRememberInfo.Checked = true;
                        chkAutoLogin.Checked = true;

                        try
                        {
                            LoadServerConfig();

                            if (StartLogin())
                            {
                                //跳转到主页面
                                Util.GLOBLE_URL = cboDB.Text.Trim();
                                this.Hide();
                                new Main().ShowDialog();
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            ExMessageBox.Show("出错。错误信息如下：\r\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    cboDB.Focus();
                    //检查登录是否需要输入验证码
                    DisplayCaptchaIfNeed();
                }
            }
            catch(Exception ex)
            {
                ExMessageBox.Show("发生了错误，错误信息为: \r\n" + ex.Message, "出误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDB.Focus();
            }

            this.Cursor = Cursors.Default;
        }

        private void DisplayCaptchaIfNeed()
        {
            if(Util.AUTH_CONFIG_DATA != null)
            {
                if (Convert.ToBoolean(Util.AUTH_CONFIG_DATA.loginCaptcha))
                {
                    //需要验证码

                    //显示验证码图片
                    if (!cboDB.Text.Trim().Equals(String.Empty))
                    {
                        picCaptcha.Image = CloudreveMiddleLayer.Entiry.Login.GetCaptcha(cboDB.Text.Trim());
                        txtCaptchaCode.Visible = true;
                        txtCaptchaCode.Text = String.Empty;
                        picCaptcha.Visible = true;
                    }
                    else
                    {
                        picCaptcha.Image = null;
                        txtCaptchaCode.Visible = false;
                        txtCaptchaCode.Text = String.Empty;
                        picCaptcha.Visible = false;
                    }
                }
            }
        }

        private void DisplayRegisterIfNeed()
        {
            if (Util.AUTH_CONFIG_DATA != null)
            {
                //显示注册按钮
                btnReg.Visible = Convert.ToBoolean(Util.AUTH_CONFIG_DATA.registerEnabled);
            }
        }

        private void LoadServerConfig()
        {
            if (!CloudreveMiddleLayer.Entiry.Login.LoadCloudreveServerAuthConfig(cboDB.Text.Trim()))
            {
                throw new Exception("获取服务器配置文件失败，\r\n请检查您填写的服务器地址和网络状况！");
            }
        }

        private void cboDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDB.SelectedIndex >=0)
            {
                this.Cursor = Cursors.WaitCursor;

                try
                {
                    LoadServerConfig();
                    DisplayCaptchaIfNeed();
                    DisplayRegisterIfNeed();
                    DisplaySavedUserNameAndPWD();

                    chkRememberInfo.Checked = true;
                }
                catch (Exception ex)
                {
                    ExMessageBox.Show("出错。错误信息如下：\r\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Cursor = Cursors.Default;
            }
            else
            {
                txtCaptchaCode.Visible = false;
                picCaptcha.Visible = false;
                picCaptcha.Image = null;
            }
        }

        private void cboDB_Leave(object sender, EventArgs e)
        {
            if(!requirementErrorProvider1.ValidateInput() || !checkFormatErrorProvider1.ValidateInput())
            {
                txtCaptchaCode.Visible = false;
                picCaptcha.Visible = false;
                picCaptcha.Image = null;
            }
            else
            {
                requirementErrorProvider1.Clear();
                checkFormatErrorProvider1.Clear();

                this.Cursor = Cursors.WaitCursor;

                try
                {
                    LoadServerConfig();
                    DisplayCaptchaIfNeed();
                    DisplayRegisterIfNeed();
                }
                catch (Exception ex)
                {
                    ExMessageBox.Show("出错。错误信息如下：\r\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Cursor = Cursors.Default;
            }
        }

        private void DisplaySavedUserNameAndPWD()
        {
            if(cboDB.SelectedIndex >=0)
            {
                DataSetSystemConfig.TBL_ServerInfoRow dr = (DataSetSystemConfig.TBL_ServerInfoRow)dtDB.Select("ServerURL = '" + cboDB.Text.Trim() + "'")[0];
                txtUserName.Text = dr.IsUserNameNull() ? "" : dr.UserName.Trim();
                txtPWD.Text = dr.IsPasswordNull() ? "" : DecryptAndEncryptionHelper.Decrypto(dr.Password.Trim());
            }
        }

        private void picCaptcha_Click(object sender, EventArgs e)
        {
            DisplayCaptchaIfNeed();
        }

        private void btnReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenURLInWebBrowser(Util.CloudreveWebURL.GET_REGISTER_URL);
        }

        private void btnForgotPWD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenURLInWebBrowser(Util.CloudreveWebURL.GET_FORGET_PWD_URL);
        }

        private void OpenURLInWebBrowser(string subURL)
        {
            if (!requirementErrorProvider1.ValidateInput() || !checkFormatErrorProvider1.ValidateInput())
            {
                return;
            }
            else
            {
                requirementErrorProvider1.Clear();
                checkFormatErrorProvider1.Clear();
            }
            string url = cboDB.Text.Trim();
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            System.Diagnostics.Process.Start(url + subURL);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(StartLogin())
            {
                //登录成功，打开主页面
                Util.GLOBLE_URL = cboDB.Text.Trim();
                this.Hide();
                new Main().ShowDialog();
                this.Close();
            }
        }

        private bool StartLogin()
        {
            if (!requirementErrorProvider1.ValidateInput() ||
                !requirementErrorProvider2.ValidateInput() ||
                !requirementErrorProvider3.ValidateInput() ||
                !checkFormatErrorProvider1.ValidateInput() ||
                !checkFormatErrorProvider2.ValidateInput())
            {
                return false;
            }

            if (txtCaptchaCode.Visible)
            {
                if (!requirementErrorProvider4.ValidateInput())
                {
                    return false;
                }
            }

            string returnMsg = String.Empty;
            int returnCode = -1;

            this.Cursor = Cursors.WaitCursor;

            if (!CloudreveMiddleLayer.Entiry.Login.AuthLogin(cboDB.Text.Trim(),
                                                       txtUserName.Text.Trim(),
                                                       txtPWD.Text.Trim(),
                                                       txtCaptchaCode.Visible,
                                                       txtCaptchaCode.Text.Trim(),
                                                       out returnCode,
                                                       out returnMsg))
            {
                ExMessageBox.Show("登录失败，请检查用户名、密码和验证码！\r\n\r\n错误信息：" + returnMsg, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayCaptchaIfNeed();
            }
            else
            {
                //将现在的登录信息添加/更新至dtDB，并加密后保存至DB.config文件
                if (cboDB.SelectedIndex >= 0)
                {
                    DataSetSystemConfig.TBL_ServerInfoRow dr = ((DataSetSystemConfig.TBL_ServerInfoRow[])dtDB.Select("ServerURL = '" + cboDB.Text.Trim() + "'"))[0];

                    if (chkRememberInfo.Checked)
                    {
                        //更新
                        if (chkAutoLogin.Checked)
                        {
                            for (int i = 0; i < dtDB.Rows.Count; i++)
                            {
                                dtDB[i].AutoLogin = false;
                            }
                        }

                        dr.Password = DecryptAndEncryptionHelper.Encrypto(txtPWD.Text.Trim());
                        dr.Cookie = DecryptAndEncryptionHelper.Encrypto(Util.GLOBLE_COOKIE);
                        dr.RememberUserInfo = chkRememberInfo.Checked;
                        dr.AutoLogin = chkAutoLogin.Checked;
                        dtDB.AcceptChanges();
                    }
                    else
                    {
                        dtDB.Rows.Remove(dr);
                        dtDB.AcceptChanges();
                    }
                }
                else if (chkRememberInfo.Checked)
                {
                    DataSetSystemConfig.TBL_ServerInfoRow dr = dtDB.NewTBL_ServerInfoRow();
                    dr.ServerUrl = cboDB.Text.Trim();
                    dr.UserName = txtUserName.Text.Trim();
                    dr.Password = DecryptAndEncryptionHelper.Encrypto(txtPWD.Text.Trim());
                    dr.Cookie = Util.GLOBLE_COOKIE;
                    dr.RememberUserInfo = chkRememberInfo.Checked;
                    dr.AutoLogin = chkAutoLogin.Checked;
                    dtDB.AddTBL_ServerInfoRow(dr);
                    dtDB.AcceptChanges();
                }

                if (!CloudreveMiddleLayer.Entiry.Login.SaveServerUrl(dtDB))
                {
                    ExMessageBox.Show("保存登录信息失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return true;
            }

            this.Cursor = Cursors.Default;

            return false;
        }
    }
}