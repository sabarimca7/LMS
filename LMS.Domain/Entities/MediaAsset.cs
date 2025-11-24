using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class MediaAsset
    {
        public int MediaId { get; set; }
        public int LessonId { get; set; }
        public string FileName { get; set; } = default!;
        public string ContentType { get; set; } = default!;
        public long? FileSizeBytes { get; set; }
        public string StoragePath { get; set; } = default!;
        public DateTime UploadedDate { get; set; }

        public Lesson Lesson { get; set; } = default!;
    }
}
