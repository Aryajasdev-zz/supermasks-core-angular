using System;
using supermasks.Core.Repositories;
using System.Security.Cryptography;
using System.Text;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class Common : ICommon
    {
        private fantasyfaceContext _context;

        public Common(fantasyfaceContext context)
        {
            _context = context;
        }

        public string getconnectionstring()
        {
            string constring = "";
            //string constring = ConfigurationManager.AppSettings["locstring"];            
            return constring;
        }

        
        public string SHA1Hash(string text)
        {
            try
            {
                SHA1 sha = new SHA1CryptoServiceProvider();
                sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
                byte[] result = sha.Hash;
                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    strBuilder.Append(result[i].ToString("x2"));
                }
                return strBuilder.ToString();
            }
            catch (Exception ex)
            {
                int linenumber = GetLineNumber(ex);                
                return null;
            }
        }

        public string getvat(decimal Amt)
        {
            try
            {
                string rvat = "";
                rvat = (Amt / 6).ToString("F");
                return rvat;
            }
            catch (Exception ex)
            {
                int linenumber = GetLineNumber(ex); ;
                
                return "0";
            }
        }

        public string getvatplus(decimal Amt)
        {
            try
            {
                string rvat = "";
                rvat = (Amt * 20 / 100).ToString("F");
                return rvat;
            }
            catch (Exception ex)
            {
                int linenumber = GetLineNumber(ex);
                return "0";
            }
        }

        public string returnname(string name, int length)
        {
            try
            {
                int len = name.Length;
                while (len < length)
                {
                    name = name + "&nbsp;";
                    len++;
                }
                return name;
            }
            catch (Exception ex)
            {
                int linenumber = GetLineNumber(ex); ;
                return name;
            }
        }

        public int getLevelNextPlus(int lvl)
        {
            switch (lvl)
            {
                case 1:
                    return 1000000;
                case 2:
                    return 1000;
                default:
                    return 1;
            }
        }

        public string toPounds(decimal num, Boolean full = false)
        {
            try
            {
                if (num < 1)
                {
                    return "&nbsp;" + (int)(num * 100) + "p";
                }
                else
                {
                    return "&pound;" + num.ToString("F");
                }
            }
            catch (Exception ex)
            {
                int linenumber = GetLineNumber(ex); ;
                
                return num.ToString();
            }
        }

        public int GetLineNumber(Exception ex)
        {
            var lineNumber = 0;
            const string lineSearch = ":line ";
            var index = ex.StackTrace.LastIndexOf(lineSearch);
            if (index != -1)
            {
                var lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length);
                if (int.TryParse(lineNumberText, out lineNumber))
                {
                }
            }
            return lineNumber;
        }

        public string RemoveSpecialCharacters(string str)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in str)
                {
                    if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_' || c == '@' || c == ' ' || c == '-' || c == '/')
                    {
                        sb.Append(c);
                    }
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                int linenumber = GetLineNumber(ex); ;
                
                return str;
            }
        }

        public string MD5Hash(string text)
        {
            try
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
                byte[] result = md5.Hash;
                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    strBuilder.Append(result[i].ToString("x2"));
                }
                return strBuilder.ToString();
            }
            catch (Exception ex)
            {
                int linenumber = GetLineNumber(ex); ;
                return null;
            }
        }
    }
}