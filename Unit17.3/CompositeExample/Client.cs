using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeExample.Components;

namespace CompositeExample
{
    /// <summary>
    /// Клиентский код
    /// </summary>
    class Client
    {
        public static void Main()
        {
            // Создание корневой папки
            Component rootFolder = new Folder("Root");

            //Создание файла - компонента низшего уровня
            Component myFile = new File("MyFile.txt");

            //Создание папки с документами
            Folder documentsFolder = new Folder("MyDocuments");

            //Добавляем файл в корневую папку
            rootFolder.Add(myFile);

            //Добавляем подпапку для документов в корневую папку
            rootFolder.Add(documentsFolder);

            //Показываем контент первой папки
            rootFolder.Display();
        }
    }
}
