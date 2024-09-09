using System;
using System.Collections.Generic;
using System.Linq;
using OOPSample.Console.Sales.Domain.Model.Aggregates;

//Crear una nueva orden de venta

        var SalesOrder = new SalesOrder(1, 1001);    // id  = 1, customerId = 1001

        // Agregar items a la orden
        SalesOrder.AddItem(2001, 2, 25.76); // 31 productId = 2001, quantity = 2, unitPrice = 15.50
        SalesOrder.AddItem(2002, 1, 25.99); // 25 productId = 2002, quantity = 1, unitPrice = 25.00
        SalesOrder.AddItem(2003, 5, 18.67); // 30 productId = 2003, quantity = 3, unitPrice = 10.00

        //Calcular el precio total de la orden
        double totalPrice = SalesOrder.CalculateTotalPrice();

        // Mostrar el precio total en la consola
        Console.WriteLine($"El precio total de la orden es {totalPrice:C}");