using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTaskList.Models
{

    // Uygulamadaki görevi temsil eden model sınıfı
    public class TaskItem
    {

        // Her görev için benzersiz bir kimlik
        // Yeni bir görev oluşturulduğunda otomatik olarak atanır
        public Guid Id { get; set; } = Guid.NewGuid();

        // Görevin başlığı, açıklaması
        public string Title { get; set; } = string.Empty;

        // Görevin tamamlanıp tamamlanmadığını tutar
        public bool IsCompleted { get; set; }

        // Görevin oluşturulduğu tarih ve saat bilgisi (şu anda kullanılmıyor, gelecekte)
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
