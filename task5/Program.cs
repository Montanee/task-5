using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст (для завершения введите пустую строку):");

        string input = "";
        string[] paragraphs;
        int wordCount = 0;
        int sentenceCount = 0;
        int paragraphCount = 0;

        // Считываем ввод текста до пустой строки
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "")
            {
                break;
            }
            input += line + "\n";
        }

        // Разделяем введенный текст на абзацы
        paragraphs = input.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
        paragraphCount = paragraphs.Length;

        // Считаем количество слов и предложений в каждом абзаце
        foreach (string paragraph in paragraphs)
        {
            string[] sentences = paragraph.Split(new char[] { '.', '!', '?' });
            sentenceCount += sentences.Length - 1; // Предполагаем, что последнее предложение заканчивается абзацем

            string[] words = paragraph.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            wordCount += words.Length;
        }

        // Выводим результаты
        Console.WriteLine($"Количество слов: {wordCount}");
        Console.WriteLine($"Количество предложений: {sentenceCount}");
        Console.WriteLine($"Количество абзацев: {paragraphCount}");
    }
}
