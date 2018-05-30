using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Trpg_DataAided
{
    public class Serializer
    {
        static string fileName = Environment.CurrentDirectory + "\\temp.dat";
        public static void Serialize(List<Player> data)
        {
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            try
            {
                BinaryFormatter binFormat = new BinaryFormatter();//创建二进制序列化器  
                binFormat.Serialize(fStream, data.ToArray());
            }
            catch (Exception)
            {

            }
            finally
            {
                fStream.Flush();
                fStream.Close();
                fStream.Dispose();
            }
        }


        public static void Deserialize(out List<Player> t)
        {
            t = null;
            if (!File.Exists(fileName)) return;

            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                BinaryFormatter formatter = new BinaryFormatter();
                Player[] list = formatter.Deserialize(fileStream) as Player[];

                t = list.ToList();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                fStream.Close();
                fStream.Dispose();
            }
        }
    }
}
