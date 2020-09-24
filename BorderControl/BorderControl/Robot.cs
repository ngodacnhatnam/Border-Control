using System;
namespace BorderControl {
    public class Robot {
        private string Model = "";
        public string ID { get; set; }
        public Robot(string id, string model)
        {
            ID = id;
            Model = model;
        }
    }
}
