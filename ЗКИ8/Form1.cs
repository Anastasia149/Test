using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗКИ8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Базовый алфавит
        private string customAlphabet = ""; // Пользовательский алфавит, сгенерированный на основе ключа
        private string currentGamma = "";   // Текущая гамма
        private Timer gammaTimer;           // Таймер для автоматического изменения гаммы

        // Генерация пользовательского алфавита на основе числового или текстового ключа.
        private void buttonGenerateAlphabet_Click(object sender, EventArgs e)
        {
            string keyInput = textBoxKey.Text; // Получение ключа из текстового поля

            // Если ключ — число, то смещаем алфавит на указанное количество символов
            if (int.TryParse(keyInput, out int numericKey))
            {
                numericKey %= alphabet.Length; // Ограничиваем сдвиг длиной алфавита
                customAlphabet = alphabet.Substring(numericKey) + alphabet.Substring(0, numericKey); // Сдвиг
            }
            // Если ключ — строка, то создаем пользовательский алфавит, начиная с уникальных символов ключа
            else if (!string.IsNullOrEmpty(keyInput) && keyInput.All(char.IsLetter))
            {
                string distinctKey = new string(keyInput.ToUpper().Distinct().ToArray()); // Уникальные буквы из ключа
                string remainingAlphabet = new string(alphabet.Except(distinctKey).ToArray()); // Остальные буквы алфавита
                customAlphabet = distinctKey + remainingAlphabet; // Объединяем в новый алфавит
            }
            else
            {
                MessageBox.Show("Введите корректный ключ: число или слово."); // Ошибка при некорректном вводе
                return;
            }

            // Показываем результат в интерфейсе
            textBoxCustomAlphabet.Text = customAlphabet;
        }

        // Генерация случайной гаммы с длиной, равной длине вводимого текста
        private void GenerateGamma()
        {
            Random random = new Random(); // Генератор случайных чисел

            // Генерация гаммы
            currentGamma = string.Join(" ", Enumerable.Range(0, textBoxInput.Text.Length)
                .Select(_ => random.Next(alphabet.Length))); // Случайные числа в диапазоне длины алфавита

            textBoxGamma.Text = currentGamma; // Отображение текущей гаммы
        }

        // Старт таймера для автоматической генерации гаммы.
        private void StartGammaTimer()
        {
            if (gammaTimer == null)
            {
                gammaTimer = new Timer();
                gammaTimer.Interval = 2000; // Интервал обновления гаммы — 2 секунды
                gammaTimer.Tick += (s, e) =>
                {
                    GenerateGamma(); // Генерация новой гаммы
                    if (!string.IsNullOrEmpty(textBoxInput.Text))
                    {
                        EncryptText(); // Перешифрование текста при изменении гаммы
                    }
                };
            }
            gammaTimer.Start(); // Запуск таймера
        }

        // Шифрование текста с использованием шифра Цезаря и гаммирования.
        private void EncryptText()
        {
            string input = textBoxInput.Text.ToUpper(); // Преобразуем текст в верхний регистр

            // Проверка, задан ли алфавит и гамма
            if (string.IsNullOrEmpty(customAlphabet) || string.IsNullOrEmpty(currentGamma))
            {
                MessageBox.Show("Сначала задайте алфавит и гамму.");
                return;
            }

            StringBuilder encodedMessage = new StringBuilder(); // Буфер для зашифрованного текста
            string[] gammaValues = currentGamma.Split(' '); // Разделяем гамму на отдельные значения

            // Шифрование текста
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                int index = alphabet.IndexOf(c); // Находим индекс символа в алфавите
                if (index != -1)
                {
                    int gamma = int.Parse(gammaValues[i % gammaValues.Length]); // Берем очередное значение гаммы
                    int encodedIndex = (index + gamma) % alphabet.Length; // Сдвиг с учетом гаммы
                    encodedMessage.Append(customAlphabet[encodedIndex]); // Получаем зашифрованный символ
                }
                else
                {
                    encodedMessage.Append('?'); // Если символ отсутствует в алфавите
                }
            }

            textBoxEncrypted.Text = encodedMessage.ToString(); // Отображаем зашифрованный текст
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            // Сначала генерируем гамму
            GenerateGamma();

            // Запускаем таймер для генерации новой гаммы каждые 2 секунды
            StartGammaTimer();

            // Теперь шифруем текст
            EncryptText();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string input = textBoxEncrypted.Text.ToUpper(); // Преобразуем текст в верхний регистр

            // Проверка, задан ли алфавит и гамма
            if (string.IsNullOrEmpty(customAlphabet) || string.IsNullOrEmpty(currentGamma))
            {
                MessageBox.Show("Сначала задайте алфавит и гамму.");
                return;
            }

            StringBuilder decodedMessage = new StringBuilder(); // Буфер для расшифрованного текста
            string[] gammaValues = currentGamma.Split(' '); // Разделяем гамму на отдельные значения

            // Расшифровка текста
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                int index = customAlphabet.IndexOf(c); // Находим индекс символа в пользовательском алфавите
                if (index != -1)
                {
                    int gamma = int.Parse(gammaValues[i % gammaValues.Length]); // Берем очередное значение гаммы
                    int originalIndex = (index - gamma + alphabet.Length) % alphabet.Length; // Обратный сдвиг
                    decodedMessage.Append(alphabet[originalIndex]); // Получаем исходный символ
                }
                else
                {
                    decodedMessage.Append('?'); // Если символ отсутствует в алфавите
                }
            }

            textBoxDecrypted.Text = decodedMessage.ToString(); // Отображаем расшифрованный текст
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            gammaTimer?.Stop(); // Останавливаем таймер на время сохранения

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files|*.txt" // Фильтр для текстовых файлов
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine(textBoxEncrypted.Text); // Сохраняем зашифрованный текст
                    writer.WriteLine(currentGamma); // Сохраняем гамму
                }
            }
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files|*.txt" // Фильтр для текстовых файлов
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string encryptedText = reader.ReadLine(); // Читаем зашифрованный текст, начиная с индекса 10 (чтобы удалить "Encrypted: ")
                    string gamma = reader.ReadLine(); ; // Читаем гамму, начиная с индекса 7 (чтобы удалить "Gamma: ")

                    // Загружаем зашифрованный текст и гамму в текстовые поля
                    textBoxEncrypted.Text = encryptedText ?? string.Empty;
                    textBoxGamma.Text = gamma ?? string.Empty;
                    currentGamma = gamma ?? string.Empty;
                }
            }
        }
    }
}
