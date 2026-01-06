using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WorkTaskList.Models;

namespace WorkTaskList.Services
{

    // Görevler üzerinde işlem yapan servis sınıfı
    // Ekleme, silme, durum değiştirme ve dosyaya kaydetme işlemlerini yönetir
    public class TaskService
    {

        // Uygulama içindeki görev listesini tutar
        private List<TaskItem> _tasks = new();

        // Görevlerin kaydedileceği JSON dosyasının yolu
        private readonly string _filePath = "Data/tasks.json";

        // Tüm görevleri döndürür
        public List<TaskItem> GetAll()
        {
            return _tasks;
        }

        // Yeni bir görev ekler
        public void Add(string title)
        {

            // Boş veya sadece boşluk içeren başlıkları engeller
            if (string.IsNullOrWhiteSpace(title))
                return;

            // Yeni görev oluşturulup listeye eklenir
            _tasks.Add(new TaskItem
            {
                Title = title
            });

            // Değişiklikten sonra dosyaya kaydedilir
            Save();
        }

        // Görevin tamamlandı-bekliyor durumunu tersine çevirir
        public void Toggle(Guid id)
        {
            // Id'ye göre görev bulunur
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return;

            // Mevcut durumun tersi atanır
            task.IsCompleted = !task.IsCompleted;

            // Değişiklik kaydedilir
            Save();
        }

        // Id'ye göre görev siler
        public void Delete(Guid id)
        {
            // Eşleşen tüm görevler listeden kaldırılır
            _tasks.RemoveAll(t => t.Id == id);
            Save();
        }

        // Görevleri JSON dosyasından yükler
        public void Load()
        {
            // Dosya yoksa işlem yapılmaz
            if (!File.Exists(_filePath)) return;

            // Dosya içeriği okunur
            var json = File.ReadAllText(_filePath);

            // JSON verisi görev listesine dönüştürülür
            _tasks = JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new();
        }


        // Görev listesini JSON dosyasına kaydeder
        private void Save()
        {
            // Data klasörü yoksa oluşturulur
            Directory.CreateDirectory("Data");


            // Görev listesi okunabilir formatta JSON'a çevrilir
            var json = JsonSerializer.Serialize(
                _tasks,
                new JsonSerializerOptions { WriteIndented = true }
            );

            // JSON verisi dosyaya yazılır
            File.WriteAllText(_filePath, json);
        }
    }
}
