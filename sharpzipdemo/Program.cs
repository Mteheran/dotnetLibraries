using ICSharpCode.SharpZipLib.Zip;

using (ZipFile zipFile = ZipFile.Create("test.zip"))
{
    zipFile.BeginUpdate();
    zipFile.Add("test.txt");
    zipFile.Add("data.csv");
    zipFile.CommitUpdate();
    zipFile.Close();
}

Console.WriteLine("File zip completed!");