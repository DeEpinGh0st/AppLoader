using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
public class OperateIniFile
{
    private static String filePath = "";
    #region API函数声明

    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section, string key,
        string val, string filePath);
    //需要调用GetPrivateProfileString的重载
    [DllImport("kernel32", EntryPoint = "GetPrivateProfileString")]
    private static extern long GetPrivateProfileString(string section, string key,
        string def, StringBuilder retVal, int size, string filePath);

    [DllImport("kernel32", EntryPoint = "GetPrivateProfileString")]
    private static extern uint GetPrivateProfileStringA(string section, string key,
        string def, Byte[] retVal, int size, string filePath);

    #endregion
    public static List<string> ReadSections()
    {
        return ReadSections(filePath);
    }

    public static List<string> ReadSections(string iniFilename)
    {
        List<string> result = new List<string>();
        Byte[] buf = new Byte[65536];
        uint len = GetPrivateProfileStringA(null, null, null, buf, buf.Length, iniFilename);
        int j = 0;
        for (int i = 0; i < len; i++)
            if (buf[i] == 0)
            {
                result.Add(Encoding.Default.GetString(buf, j, i - j));
                j = i + 1;
            }
        return result;
    }

    public static List<string> ReadKeys(String SectionName)
    {
        return ReadKeys(SectionName, filePath);
    }

    public static List<string> ReadKeys(string SectionName, string iniFilename)
    {
        List<string> result = new List<string>();
        Byte[] buf = new Byte[65536];
        uint len = GetPrivateProfileStringA(SectionName, null, null, buf, buf.Length, iniFilename);
        int j = 0;
        for (int i = 0; i < len; i++)
            if (buf[i] == 0)
            {
                result.Add(Encoding.Default.GetString(buf, j, i - j));
                j = i + 1;
            }
        return result;
    }
    public static void SetFilePath(String filepath)
    {
        filePath = filepath;
    }

    public static string GetFilePath()
    {
        return filePath;
    }
    #region 读Ini文件

    public static string ReadIniData(string Section, string Key, string NoText)
    {
        return ReadIniData(Section, Key, NoText, filePath);
    }
    public static string ReadIniData(string Section, string Key, string NoText, string iniFilePath)
    {
        if (File.Exists(iniFilePath))
        {
            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString(Section, Key, NoText, temp, 1024, iniFilePath);
            return temp.ToString();
        }
        else
            return String.Empty;
    }

    #endregion

    #region 写Ini文件

    public static bool WriteIniData(string Section, string Key, string Value)
    {
        return WriteIniData(Section, Key, Value, filePath);
    }
    public static bool WriteIniData(string Section, string Key, string Value, string iniFilePath)
    {
        //if (File.Exists(iniFilePath))
        //{
        //    long OpStation1 = WritePrivateProfileString(Section, Key, Value, iniFilePath);
        //    if (OpStation1 == 0)
        //        return false;
        //    else
        //        return true;
        //}
        //else
        //    return false;
        //文件不存在会自动创建
        long OpStation1 = WritePrivateProfileString(Section, Key, Value, iniFilePath);
        if (OpStation1 == 0)
            return false;
        else
            return true;
    }
    #endregion
}