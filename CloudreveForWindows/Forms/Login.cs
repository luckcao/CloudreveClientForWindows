using CloudreveMiddleLayer;
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
        DataTable dtDB = new DataTable();

        public Login()
        {
            InitializeComponent();
            //string str = DecryptAndEncryptionHelper.Encrypto("y2ridg9t");
            //Console.WriteLine(DecryptAndEncryptionHelper.Decrypto(str));
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                string dbFile = Util.GetApplicationPath() + "DB.config";
                if (File.Exists(dbFile))
                {
                    //如果DB.config文件存在

                    string config = TextFileHelper.ReadTextFile(dbFile);
                    if (string.IsNullOrEmpty(config))
                    {
                        //说明读取DB.config文件失败
                        throw new Exception("读取本地配置文件失败！");
                    }

                    config = DecryptAndEncryptionHelper.Decrypto(config);
                    if (!Util.DataTableReadXML(config, dtDB) || dtDB.Rows.Count == 0)
                    {
                        InitialDataTable();
                        throw new Exception("转换本地配置文件失败！");
                    }

                    int autoLoginRowIndex = -1;
                    for (int i = 0; i < dtDB.Rows.Count; i++)
                    {
                        cboDB.Items.Insert(0, dtDB.Rows[i]["ServerUrl"].ToString());
                        if (Convert.ToBoolean(dtDB.Rows[i]["AutoLogin"]))
                        {
                            autoLoginRowIndex = i;
                        }
                    }
                    if (autoLoginRowIndex != -1)
                    {
                        cboDB.SelectedIndex = 0;
                        txtUserName.Text = dtDB.Rows[autoLoginRowIndex]["UserName"].ToString();
                        txtPWD.Text = dtDB.Rows[autoLoginRowIndex]["Password"].ToString();
                        chkRememberInfo.Checked = true;
                        chkAutoLogin.Checked = true;
                        if (!Util.LoadCloudreveServerAuthConfig(cboDB.Text.Trim()))
                        {
                            throw new Exception("获取服务器配置文件失败，\r\n请检查您填写的服务器地址和网络状况！");
                        }

                        if (CloudreveMiddleLayer.Entiry.Login.StartAutoLogin())
                        {
                            //登录成功！
                            ExMessageBox.Show("登录成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //将dtDB加密保存至文件
                            string dtXML = Util.DataTableWriteXML(dtDB);
                            dtXML = DecryptAndEncryptionHelper.Encrypto(dtXML);
                            if (!TextFileHelper.WriteTextFile(dbFile, new String[] { dtXML }, false))
                            {
                                throw new Exception("更新登录配置文件失败...");
                            }
                            //跳转到主页面
                        }
                        else
                        {
                            //登录失败，继续停留在登录页面
                        }
                    }
                }
                else
                {
                    //DB.config文件不存在，则初始化dtDB
                    InitialDataTable();
                    cboDB.Focus();
                }
            }
            catch(Exception ex)
            {
                ExMessageBox.Show("发生了错误，错误信息为: \r\n" + ex.Message, "出误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

            this.Cursor = Cursors.Default;
        }

        private void InitialDataTable()
        {
            dtDB.Columns.Add("ServerUrl", Type.GetType("System.String"));
            dtDB.Columns.Add("UserName", Type.GetType("System.String"));
            dtDB.Columns.Add("Password", Type.GetType("System.String"));
            dtDB.Columns.Add("Cookie", Type.GetType("System.String"));
            dtDB.Columns.Add("IsDefault", Type.GetType("System.Boolean"));
            dtDB.Columns.Add("AutoLogin", Type.GetType("System.Boolean"));
            dtDB.AcceptChanges();

        }
    }
}
