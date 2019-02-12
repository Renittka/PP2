﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    enum Viewmode // enumerator list to understand mode (folder or file)
    {
        ShowDirContent,
        ShowFileContent
    }

    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\User\Documents\Test");
            Stack<Layer> history = new Stack<Layer>();

            history.Push(
                new Layer
                {
                    Content = dirInfo.GetFileSystemInfos() // get files and folders
            }
            );
            Viewmode viewMode = Viewmode.ShowDirContent; // default case - folder

            bool quit = false;
            while (!quit)
            {
                if (viewMode == Viewmode.ShowDirContent)
                {
                    history.Peek().Draw(); // drawing the interface
                }
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (history.Peek().SelectedItem -1 < 0)
                        {
                            history.Peek().SelectedItem = history.Peek().Content.Length - 1;
                        }
                        else
                        {
                            history.Peek().SelectedItem--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (history.Peek().SelectedItem +1 >= history.Peek().Content.Length)
                        {
                            history.Peek().SelectedItem = 0;
                        }
                            else
                        {
                            history.Peek().SelectedItem++;
                        }
                        break;

                    case ConsoleKey.Enter:
                        int x = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo = history.Peek().Content[x];

                        if(fileSystemInfo.GetType() == typeof(DirectoryInfo)) // if directory - getting its content
                        {
                            viewMode = Viewmode.ShowDirContent;
                            DirectoryInfo selectedDir = fileSystemInfo as DirectoryInfo;
                            history.Push(new Layer
                            {
                                Content = selectedDir.GetFileSystemInfos()

                            });
                        }
                        else
                        { // if file - reading the file
                            viewMode = Viewmode.ShowFileContent;

                            using (FileStream fs = new FileStream(fileSystemInfo.FullName, FileMode.Open, FileAccess.Read))
                            {
                                using(StreamReader sr = new StreamReader(fs))
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine(sr.ReadToEnd());
                                }
                            }
                        }
                        break;

                    case ConsoleKey.F6: //rename
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        string name = Console.ReadLine();
                        int x3 = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo3 =  history.Peek().Content[x3];
                        if (fileSystemInfo3.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo directoryInfo = fileSystemInfo3 as DirectoryInfo;
                            Directory.Move(fileSystemInfo3.FullName, directoryInfo.Parent.FullName + "/" + name);
                            history.Peek().Content = directoryInfo.Parent.GetFileSystemInfos();
                        }
                        else
                        {
                            FileInfo fileInfo = fileSystemInfo3 as FileInfo;
                            File.Move(fileSystemInfo3.FullName, fileInfo.Directory.FullName + "/" + name);
                            history.Peek().Content = fileInfo.Directory.GetFileSystemInfos();
                        }
                        break;

                    case ConsoleKey.F8: // delete
                        int x2 = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo2 = history.Peek().Content[x2];
                            history.Peek().SelectedItem--;
                        if (fileSystemInfo2.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo directoryInfo = fileSystemInfo2 as DirectoryInfo;
                            Directory.Delete(fileSystemInfo2.FullName, true); // if folder is not empty (true) delete
                            history.Peek().Content = directoryInfo.Parent.GetFileSystemInfos();
                        }
                        else
                        {
                            FileInfo fileInfo = fileSystemInfo2 as FileInfo;
                            File.Delete(fileSystemInfo2.FullName);
                            history.Peek().Content = fileInfo.Directory.GetFileSystemInfos();
                        }
                        break;

                    case ConsoleKey.Backspace:
                        if (viewMode == Viewmode.ShowDirContent)
                        {
                            history.Pop(); // clear the last layer
                        }
                        else
                        { // if file - draw interface and set diectory mode
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            viewMode = Viewmode.ShowDirContent;
                        }
                        break;

                    case ConsoleKey.Escape:
                        quit = true;
                        break;
                }
            }
        }
    }
}
