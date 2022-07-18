﻿namespace Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Truck : IVehicle
    {
        private double _fuelQuantity;
        private double _fuelConsumption;
        public Truck(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public double FuelQuantity
        {
            get => this._fuelQuantity;
            private set
            {
                this._fuelQuantity = value;
            }
        }
        public double FuelConsumption
        {
            get => this._fuelConsumption;
            private set
            {
                this._fuelConsumption = value + 1.6;
            }
        }
        public string Drive(double km)
        {
            double neededLiters = this.FuelConsumption * km;
            if (this.FuelQuantity - neededLiters >= 0)
            {
                this.FuelQuantity -= neededLiters;
                return $"Truck travelled {km} km";
            }
            else
            {
                return $"Truck needs refueling";
            }
        }
        public void Refuel(double fuel)
        {
            this.FuelQuantity += fuel * 0.95;
        }
    }
}
