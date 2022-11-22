﻿namespace StreamWriterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flobbo f = new Flobbo("blue yellow");
            StreamWriter sw = f.Snobbo();
            f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
        }
        class Flobbo
        {
            private string zap;
            public Flobbo(string zap)
            {
                this.zap = zap;
            }
            public StreamWriter Snobbo()
            {
                return new StreamWriter("C:\\CSProjects\\learning\\StreamWriterApp\\macaw.txt");
            }
            public bool Blobbo(bool Already, StreamWriter sw)
            {
                if (Already)
                {
                    sw.WriteLine(zap); 
                    sw.Close(); 
                    return false;
                }
                else
                {
                    sw.WriteLine(zap);
                    zap = "red orange";
                    return true;
                }
            }

            public bool Blobbo(StreamWriter sw)
            {
                sw.WriteLine(zap);
                zap = "green purple";
                return false;
            }
        }
    }
}
