using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SPC.Start_Menu
{
    class New_Project
    {
        private String projectName;
        public New_Project(String projectName)
        {
            this.projectName = projectName;
            createNewProject();
        }

        //Methode mit der das neue Projekt angelegt wird. Überprüft zunächst ob der Ordner zum Speichern vorhanden ist. Ansonsten wird ein neuer erstellt. 
        public void createNewProject()
        {
            if (checkProjectDirectory() == true)
            {
                createProjectFile();
            }
            else
            {
                createProjectDirectory();
                createProjectFile();
            }
        }

        //Methode die Überprüft ob der Ordner, in welchem die Dateien gespeichert werden, vorhanden ist
        public Boolean checkProjectDirectory()
        {
            if (Directory.Exists("Saving"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Erstellt den neuen Ordner zum Speichern der Datei
        public void createProjectDirectory()
        {
            Directory.CreateDirectory("Savings");
           
        }
        
        //Erstellt eine Datei im Format txt mit dem übergebenem Projektnamen. 
        public void createProjectFile()
        {
            String path = "savings/" + projectName + ".txt";
            using (FileStream fs = File.Create(path))
            {
              
            }
        }
    }
}
