﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleNamespace;

namespace Chapter9
{
    class Exercise5
    {
        public void Show()
        {
            Console.WriteLine(@"
Создайте проект консольного приложения с именем Traffic, ссылающийся на проект 
Vehicles.dll (из упражнения 4). Добавьте в него функцию AddPasenger, принимаю-
щую любой объект с интерфейсом IPassengerCarrier. Для проверки работоспособно-
сти кода вызовите эту функцию для экземпляров всех объектов, которые поддерживают 
этот интерфейс, и выводите результаты с помощью метода ToString, унаследованного 
от класса System.Object.
                            ");
            IPassengerCarrier iPassenger;
            SUV suv = new SUV();
            Compact compact = new Compact();
            PassengerTrain passegerTrain = new PassengerTrain();
            iPassenger = suv;
            Console.WriteLine(iPassenger.ToString());
            iPassenger = compact;
            Console.WriteLine(iPassenger.ToString());
            iPassenger = passegerTrain;
            Console.WriteLine(iPassenger.ToString());
            Console.WriteLine();
        }
    }
}
