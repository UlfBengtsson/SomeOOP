using System;

namespace SomeOOP.Models
{
    public class Car
    {
        private Guid id;
        public Guid Id { get { return id; } }

        string modelName;

        Brand brand;

        string color;
        
        string regPlate;
        public string RegPlate { get { return regPlate; } set { regPlate = value; } }


        private Car(Guid id)
        {
            this.id = id;
        }

        public Car(Guid id, string model, Brand brand) : this(id)
        {
            this.modelName = model;
            this.brand = brand;
        }

        public Car(Guid id, string model, Brand brand, string color) : this(id, model, brand)
        {
            this.color = color;
        }


        public string Info()
        {
            return $"Id: {id}\nBrand: {brand.Name}\nModel: {modelName}\nColor: {color}\nReg.Plate: {regPlate}";
        }

    }
}
