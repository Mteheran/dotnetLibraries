using ICSharpCode.SharpZipLib.Zip;

//using (ZipFile zipFile = ZipFile.Create("test.zip"))

// using (ZipFile zipFile = new ZipFile("test.zip"))
// {
//     zipFile.BeginUpdate();
//     zipFile.Add("test2.txt");
//     //zipFile.Add("test.txt");
//     //zipFile.Add("data.csv");
//     zipFile.CommitUpdate();
//     zipFile.Close();
// }

// Console.WriteLine("File zip completed");

using (ZipFile zipFile = new ZipFile("test.zip"))
{
    foreach(ZipEntry zip in zipFile)
    {
        Console.WriteLine(zip.Name);
        using (StreamReader reader = new StreamReader(zipFile.GetInputStream(zip)))
        {
            Console.WriteLine($"Contenido: {reader.ReadToEnd()}");
            reader.Close();
        }
    }
}