using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 加密解密类
    /// </summary>
    public class EncryptDecrypt
    {
        //默认密钥向量
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串，失败返回源串</returns>
        /// <key>82264601 技术部电话</key>
        public static string EncryptDES(string encryptString, string encryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        public static string DecryptDES(string decryptString, string decryptKey)
        {
            try
            {

                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                int count = mStream.ToArray().Length;
                return Encoding.UTF8.GetString(mStream.ToArray(), 0, count);

            }
            catch
            {
                return decryptString;
            }
        }


        public string Encrypt(string EncryptText, int Key)
        {
            int lngLength;
            string strAllEncrypt = "";
            string strAllLength = "";
            string strEncrypt;
            string strLength;


            lngLength = EncryptText.Length;
            for (int i = 0; i < lngLength; i++)
            {
                //    '取出每个字符的ASCII码,然后加上KEY值,再转换成16制
                //strEncrypt = Hex(Asc(Mid(EncryptText, i, 1)) + Key);
                //strEncrypt = Convert.ToString(Convert.ToInt16(Encoding.ASCII.GetBytes(EncryptText.Substring(i, 1))[0] + Key), 16);
                strEncrypt = Convert.ToString(Convert.ToInt16(GetAscii(EncryptText.Substring(i, 1)) + Key), 16);



                //Convert.ToString(Convert.ToInt16(textBox6.Text), 16);

                strLength = strEncrypt.Length.ToString();



                if (strAllEncrypt.Trim() == "")
                {
                    strAllEncrypt = strEncrypt;
                    strAllLength = "@" + strLength;
                }
                else
                {
                    strAllEncrypt = strAllEncrypt + strEncrypt;
                    strAllLength = strAllLength + strLength;
                }

            }
            string str = strAllEncrypt + strAllLength;
            str = str.ToUpper();
            return str;
        }

        public string Decrypt(string DecryptText, int Key)
        {
            string[] arrData;

            int lngLength;
            string strAllDecrypt;
            string strAllLength;
            string strDecrypt;
            //string strLength;
            int lngAllDecryptLength;
            int j;
            int n;
            string strDecryptText = "";

            arrData = Regex.Split(DecryptText, "@");
            strAllDecrypt = arrData[0];
            strAllLength = arrData[1];
            lngLength = strAllLength.Length;
            lngAllDecryptLength = 0;

            for (int i = 0; i < lngLength; i++)
            {
                j = Convert.ToInt32(strAllLength.Substring(i, 1));
                n = Convert.ToInt32(DecryptText.Substring(lngAllDecryptLength, j), 16) - Key;

                //Convert.ToInt32(textBox7.Text, 16).ToString();
                //Encoding e = Encoding.GetEncoding("gb18030");
                Encoding e = Encoding.GetEncoding(0);

                //e.GetChars(52946);
                //char.Parse("s");
                char chr = (char)n;
                strDecrypt = chr.ToString();
                if (strDecryptText.Trim() == "")
                {
                    strDecryptText = strDecrypt;
                }
                else
                {
                    strDecryptText = strDecryptText + strDecrypt;
                }

                lngAllDecryptLength = lngAllDecryptLength + j;


            }
            return strDecryptText;

        }

        //Function Decrypt(DecryptText As String, Key As Long) As String

        //    strAllDecrypt = arrData(0)
        //    strAllLength = arrData(1)
        //    lngLength = Len(strAllLength)
        //    lngAllDecryptLength = 1
        //    For i = 1 To lngLength
        //        'j 单个字符的长度
        //        j = Mid(strAllLength, i, 1)

        //        strDecrypt = Chr(("&H" & Mid(DecryptText, lngAllDecryptLength, j)) - Key)

        //        If Trim(strDecryptText) = "" Then
        //            strDecryptText = strDecrypt
        //        Else
        //            strDecryptText = strDecryptText & strDecrypt
        //        End If
        //        lngAllDecryptLength = lngAllDecryptLength + j
        //    Next

        //    Decrypt = strDecryptText

        //End Function



        /// <summary>
        /// 得到字符的ascii码
        /// </summary>
        public static int GetAscii(string chr)
        {
            //Encoding ecode = Encoding.GetEncoding("gb18030");
            Encoding ecode = Encoding.GetEncoding(0);

            byte[] codebytes = ecode.GetBytes(chr.ToString());
            if (IsTwoBytesChar(chr))
            {

                // 双字节码为高位乘256，再加低位
                // 该为无符号码，再减65536
                return (int)codebytes[0] * 256 + (int)codebytes[1] - 65536;
            }
            else
            {
                return (int)codebytes[0];
            }
        }

        /// <summary>
        /// 是否为双字节字符。
        /// </summary>
        public static bool IsTwoBytesChar(string chr)
        {
            string str = chr.ToString();
            // 使用中文支持编码
            //Encoding ecode = Encoding.GetEncoding("gb18030");
            Encoding ecode = Encoding.GetEncoding(0);
            if (ecode.GetByteCount(str) == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
