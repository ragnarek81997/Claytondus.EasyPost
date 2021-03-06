﻿using System;

namespace Claytondus.EasyPost.Models {
    public class PostageLabel {
        public string id { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public int date_advance { get; set; }
        public string integrated_form { get; set; }
        public DateTime label_date { get; set; }
        public int label_resolution { get; set; }
        public string label_size { get; set; }
        public string label_type { get; set; }
        public string label_url { get; set; }
        public string label_file_type { get; set; }
        public string label_pdf_url { get; set; }
        public string label_epl2_url { get; set; }
        public string label_zpl_url { get; set; }
        public string mode { get; set; }
    }
}
