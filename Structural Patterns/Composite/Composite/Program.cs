using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component fileSystem = new Directory("File system");
            Component diskC = new Directory("Disk С");
            Component pngFile = new File("edrenbaton.png");
            Component docxFile = new File("tvoyudiviziyou.docx");
            diskC.Add(pngFile);
            diskC.Add(docxFile);
            fileSystem.Add(diskC);
            fileSystem.Print();
            Console.WriteLine();
            diskC.Remove(pngFile);
            Component docsFolder = new Directory("My memes");
            Component txtFile = new File("povezlopovezlo.txt");
            Component csFile = new File("Program.cs");
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskC.Add(docsFolder);

            fileSystem.Print();

            Console.Read();
        }
    }
}
