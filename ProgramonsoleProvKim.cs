using System;
using System.IO;

class Program
{
    static void Main()
    {
        string currentPath = Directory.GetCurrentDirectory(); // Начальный путь
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine($"Текущий каталог: {currentPath}");
            Console.WriteLine("1. Просмотреть содержимое каталога");
            Console.WriteLine("2. Перейти в каталог");
            Console.WriteLine("3. Вернуться в родительский каталог");
            Console.WriteLine("4. Создать новый каталог");
            Console.WriteLine("5. Создать новый текстовый файл");
            Console.WriteLine("6. Удалить файл или каталог");
            Console.WriteLine("7. Выйти из приложения");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewDirectoryContent(currentPath);
                    break;
                case "2":
                    currentPath = ChangeDirectory(currentPath);
                    break;
                case "3":
                    currentPath = GoToParentDirectory(currentPath);
                    break;
                case "4":
                    CreateDirectory(currentPath);
                    break;
                case "5":
                    CreateTextFile(currentPath);
                    break;
                case "6":
                    DeleteFileOrDirectory(currentPath);
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }

    // Просмотр содержимого каталога
    static void ViewDirectoryContent(string path)
    {
        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            Console.WriteLine("\nСодержимое каталога:");

            // Показать каталоги
            var directories = dirInfo.GetDirectories();
            foreach (var dir in directories)
            {
                Console.WriteLine($"[D] {dir.Name}");
            }

            // Показать файлы
            var files = dirInfo.GetFiles();
            foreach (var file in files)
            {
                Console.WriteLine($"[F] {file.Name}");
            }

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при просмотре содержимого: {e.Message}");
        }
    }

    // Перемещение в другой каталог
    static string ChangeDirectory(string currentPath)
    {
        Console.Write("\nВведите путь к каталогу: ");
        string newPath = Console.ReadLine();

        if (Directory.Exists(newPath))
        {
            return newPath;
        }
        else
        {
            Console.WriteLine("Каталог не существует.");
            Console.ReadKey();
            return currentPath;
        }
    }

    // Возврат в родительский каталог
    static string GoToParentDirectory(string currentPath)
    {
        string parentPath = Directory.GetParent(currentPath)?.FullName;

        if (parentPath != null)
        {
            return parentPath;
        }
        else
        {
            Console.WriteLine("Вы находитесь в корневом каталоге.");
            Console.ReadKey();
            return currentPath;
        }
    }

    // Создание нового каталога
    static void CreateDirectory(string currentPath)
    {
        Console.Write("\nВведите имя нового каталога: ");
        string dirName = Console.ReadLine();
        string newDirPath = Path.Combine(currentPath, dirName);

        try
        {
            Directory.CreateDirectory(newDirPath);
            Console.WriteLine($"Каталог '{dirName}' создан.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при создании каталога: {e.Message}");
        }
        Console.ReadKey();
    }

    // Создание нового текстового файла
    static void CreateTextFile(string currentPath)
    {
        Console.Write("\nВведите имя нового текстового файла: ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(currentPath, fileName);

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                Console.WriteLine("Введите текст для файла:");
                string content = Console.ReadLine();
                writer.WriteLine(content);
                Console.WriteLine($"Текстовый файл '{fileName}' создан.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при создании файла: {e.Message}");
        }

        Console.ReadKey();
    }

    // Удаление файла или каталога
    static void DeleteFileOrDirectory(string currentPath)
    {
        Console.Write("\nВведите имя файла или каталога для удаления: ");
        string name = Console.ReadLine();
        string fullPath = Path.Combine(currentPath, name);

        if (Directory.Exists(fullPath))
        {
            Console.Write("Вы уверены, что хотите удалить этот каталог? (y/n): ");
            string confirmation = Console.ReadLine();

            if (confirmation.ToLower() == "y")
            {
                try
                {
                    Directory.Delete(fullPath, true); // Удаление каталога с содержимым
                    Console.WriteLine($"Каталог '{name}' удален.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка при удалении каталога: {e.Message}");
                }
            }
        }
        else if (File.Exists(fullPath))
        {
            Console.Write("Вы уверены, что хотите удалить этот файл? (y/n): ");
            string confirmation = Console.ReadLine();

            if (confirmation.ToLower() == "y")
            {
                try
                {
                    File.Delete(fullPath);
                    Console.WriteLine($"Файл '{name}' удален.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка при удалении файла: {e.Message}");
                }
            }
        }
        else
        {
            Console.WriteLine("Файл или каталог не найден.");
        }

        Console.ReadKey();
    }
}