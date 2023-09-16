using CloudreveMiddleLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.Entiry
{
    public class SystemSetting
    {
        public enum SettingsName
        {
            所有设置 = -1,
            点击图片文件时自动预览图片 = 1
        }

        public static string GetSettings(SettingsName name)
        {
            if (name == SettingsName.所有设置)
            {
                throw new Exception("此处只能获取具体某一设置项的值，不能获得所有设置项的值。如果您想要获取所有设置项的值，请调用其他函数！");
            }
            using (DataHelper da = new DataHelper())
            {
                da.AddParameter("@SettingID", (int)name);
                string sql = " SELECT " +
                             "      s.SettingID, " +
                             "      s.SettingDesc, " +
                             "      s.SettingType, " +
                             "      s.ValueType, " +
                             "      s.SettingValue " +
                             " FROM " +
                             "      TBL_SettingsInfo s " +
                             " Where " +
                             "      s.SettingID = @SettingID;";
                DataSet.DataSetSystemConfig.TBL_SettingsInfoDataTable dt = new DataSet.DataSetSystemConfig.TBL_SettingsInfoDataTable();
                if (da.GetData(sql, dt))
                {
                    return dt[0].SettingValue;
                }
                else
                {
                    throw new Exception("没有找到\"" + name.ToString() + "\"的设置项，请核实！");
                }
            }
        }

        public static DataSet.DataSetSystemConfig.TBL_SettingsInfoDataTable GetAllSettings()
        {
            using (DataHelper da = new DataHelper())
            {
                string sql = " SELECT " +
                             "      s.SettingID, " +
                             "      s.SettingDesc, " +
                             "      s.SettingType, " +
                             "      s.ValueType, " +
                             "      s.SettingValue " +
                             " FROM " +
                             "      TBL_SettingsInfo s " +
                             " Order By " +
                             "      s.SettingType ;";
                DataSet.DataSetSystemConfig.TBL_SettingsInfoDataTable dt = new DataSet.DataSetSystemConfig.TBL_SettingsInfoDataTable();
                da.GetData(sql, dt);
                return dt;
            }
        }

        public static bool UpdateSetting(SettingsName name, string value)
        {
            using (DataHelper da = new DataHelper())
            {
                da.AddParameter("@SettingID", (int)name);
                da.AddParameter("@SettingValue", value);

                string sql = " Update " +
                             "      TBL_SettingsInfo " +
                             " Set " +
                             "      SettingValue = @SettingValue " +
                             " Where " +
                             "      s.SettingID = @SettingID;";

                return da.ExecuteSQL(sql);
            }

        }
    }
}