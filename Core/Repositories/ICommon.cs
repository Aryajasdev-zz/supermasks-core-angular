using System;
using System.Drawing;
using System.Net.Mime;

namespace supermasks.Core.Repositories
{
    public interface ICommon
    {
        string getconnectionstring();
        string SHA1Hash(string text);
        string getvat(decimal Amt);
        string getvatplus(decimal Amt);
        string returnname(string name, int length);
        int getLevelNextPlus(int lvl);
        string toPounds(decimal num, Boolean full = false);
        int GetLineNumber(Exception ex);
        string RemoveSpecialCharacters(string str);
        string MD5Hash(string text);

    }
}