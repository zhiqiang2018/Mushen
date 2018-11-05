using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mushen.Fuwen
{
    public interface ILog
    {
        string LogFolder { get; set; }

        void Begin(string logFile);

        void Begin(string logFile, bool append);

        void Flush();

        void Normal(string msg);

        void Warning(string msg);

        void Error(string msg);

        void End();
    }

    public class Log2File : ILog
    {
        private string logFolder = null;
        private StreamWriter sw = null;
        private FileStream fs = null;

        public string LogFolder { get { return logFolder; } set { this.logFolder = value; } }

        public void Begin(string logFile)
        {
            Begin(logFile, true);
        }

        public void Begin(string logFile, bool append)
        {
            try
            {
                fs = new FileStream(logFile, append ? FileMode.Append : FileMode.Create, FileAccess.Write, FileShare.Read);
                sw = new StreamWriter(fs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void End()
        {
            if (this.sw != null)
            {
                try
                {
                    sw.Flush();
                    sw.Close();
                    sw = null;
                    fs = null;
                }
                catch { }
            }
        }

        public void Error(string msg)
        {
            if (sw != null)
            {
                try
                {
                    sw.Write(msg);
                }
                catch
                { }
            }
        }

        public void Flush()
        {
            if (sw != null)
            {
                try
                {
                    sw.Flush();
                }
                catch
                { }
            }
        }

        public void Normal(string msg)
        {
            if (sw != null)
            {
                try
                {
                    sw.Write(msg);
                }
                catch
                { }
            }
        }

        public void Warning(string msg)
        {
            if (sw != null)
            {
                try
                {
                    sw.Write(msg);
                }
                catch
                { }
            }
        }
    }
}
