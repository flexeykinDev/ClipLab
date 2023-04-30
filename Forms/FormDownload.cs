using Kursach.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;
using NReco.VideoConverter;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection.Emit;

namespace Kursach.Forms
{
    public partial class FormDownload : Form
    {
        public FormDownload()
        {
            InitializeComponent();
            LoadTheme();

        }
        private void FormDownload_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
             lbl1.ForeColor = ThemeColor.SecondaryColor;
             lbl2.ForeColor = ThemeColor.SecondaryColor;
             lblSaveAs.ForeColor = ThemeColor.SecondaryColor;
        }

        void AlertBox(Color backColor, Color color, string title, string text, Image icon)
        {
            AlertBox aRt = new AlertBox();
            aRt.BackColor = backColor;
            aRt.ColorAlertBox = color;
            aRt.TitleAlertBox = title;
            aRt.TextAlertBox = text;
            aRt.IconeAlertBox = icon;
            aRt.ShowDialog();
            aRt.TopMost = false;


        }




        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSavePath.Text = folderBrowserDialog.SelectedPath;
                }
            }

        }

    


        private async void btnDownload_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Получаем URL видео из текстового поля
                string videoUrl = txtUrl.Text;
                if (string.IsNullOrWhiteSpace(videoUrl))
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    AlertBox(Color.LightPink, Color.DarkRed, "Ошибка :(", "Вставьте ссылку на видео!", Properties.Resources.Error_ICO30);
                }
                Regex regex = new Regex(@"^(https?\:\/\/)?(www\.youtube\.com|youtu\.?be)\/.+$");
                if (regex.IsMatch(videoUrl))
                {
                    // Создаем объект для работы с YouTube
                    var youTube = YouTube.Default;

                    // Получаем информацию о видео
                    var video = youTube.GetVideo(videoUrl);
                    // Получаем название видео






                    string videoTitle = video.Title;

                    string invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                    string safeTitle = string.Join("_", video.Title.Split(invalidChars.ToCharArray()));
                    string fullName = safeTitle + video.FileExtension;

                    if (string.IsNullOrWhiteSpace(txtSavePath.Text))
                    {
                        System.Media.SystemSounds.Asterisk.Play();
                        AlertBox(Color.LightPink, Color.DarkRed, "Ошибка :(", "Укажите путь сохранения!", Properties.Resources.Error_ICO30);
                    }
                    if (!string.IsNullOrWhiteSpace(txtSavePath.Text))
                    {
                        // Получаем путь для сохранения видео
                        string savePath = txtSavePath.Text;

                        // Добавляем название файла к пути

                        if (!savePath.EndsWith("\\"))
                        {
                            savePath += "\\";
                        }
                        savePath += fullName;
                        // Запускаем операцию загрузки видео в отдельном потоке

                        
                            await Task.Run(() =>
                            {
                                AlertBox(Color.LightBlue, Color.DodgerBlue, "Ожидайте ( ͡° ͜ʖ ͡°)", "скачивания файла", Properties.Resources.Hint_ICO30);

                                // Получаем данные видео в виде массива байт
                                byte[] videoData = video.GetBytes();


                                // Сохраняем видео на диск
                                if (File.Exists(savePath))
                                {

                                    System.Media.SystemSounds.Asterisk.Play();
                                    AlertBox(Color.LightGoldenrodYellow, Color.Gold, "Предупреждение :O", "Файл уже существует.", Properties.Resources.Warning_ICO30);
                                }
                                else
                                {
                                    // File.WriteAllBytes(savePath, videoData);
                                    bool convertToMp3 = chkAudioOnly.Checked;

                                    if (convertToMp3)
                                    {
                                        // Создаем объект для конвертации видео
                                        var ffMpeg = new NReco.VideoConverter.FFMpegConverter();

                                        var conv = new FFMpegConverter();
                                        // Сохраняем видео на диск
                                        File.WriteAllBytes(savePath, videoData);
                                        Thread.Sleep(500);
                                        if (File.Exists(savePath))
                                        {
                                            // Путь к исходному файлу
                                            var sourcePath = savePath;
                                            //var outputPath = savePath + ".mp3";
                                            var outputPath = Path.Combine(Path.GetDirectoryName(savePath), Path.GetFileNameWithoutExtension(savePath)) + ".mp3";
                                            // Конвертируем видео в MP3
                                            ffMpeg.ConvertMedia(sourcePath.Trim(), outputPath.Trim(), "mp3");
                                            if (File.Exists(outputPath))
                                            {
                                                File.Delete(sourcePath);
                                            }
                                        }


                                    }
                                    else
                                    {
                                        // Сохраняем видео на диск
                                        File.WriteAllBytes(savePath, videoData);
                                    }


                                    System.Media.SystemSounds.Asterisk.Play();
                                    AlertBox(Color.LightGray, Color.SeaGreen, "Успех :)", "Видео успешно скачано!", Properties.Resources.Success_ICO30);
                                }
                            
                            });

                    }
                }
                else
                {
                    
                    System.Media.SystemSounds.Asterisk.Play();
                    AlertBox(Color.LightPink, Color.DarkRed, "Ошибка :(", "Ссылка не верна.", Properties.Resources.Error_ICO30);
                }
            }
            catch(System.ComponentModel.Win32Exception ex)
            {
                if (ex.Message.Contains("403")) // Если сообщение об ошибке содержит "403"
                {
                    
                    System.Media.SystemSounds.Asterisk.Play();
                    AlertBox(Color.LightBlue, Color.DodgerBlue, "Ошибка доступа", "перезапустите приложение!", Properties.Resources.Hint_ICO30);
                    AlertBox(Color.LightBlue, Color.DodgerBlue, "Ошибка доступа", "недостаточно прав для открытия этой ссылки",  Properties.Resources.Hint_ICO30);

                }
                else // Если другая ошибка
                {

                    System.Media.SystemSounds.Asterisk.Play();
                    
                    AlertBox(Color.LightPink, Color.DarkRed, "Ошибка :(", "Ошибка", Properties.Resources.Error_ICO30);
                    
                }
            }

        }
    }
}

