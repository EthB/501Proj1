﻿//------------------------------------------------------------------------------
// SalesTransaction.CS
// Author: Ethan Bartel
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// SalesTransaction represents a single transaction made by the user
/// if the user buys something
/// </summary>
public class SalesTransaction
{
    /// <summary>
    /// the list of items that the user is buying
    /// </summary>
    private List<Item> cart = new List<Item>();

    /// <summary>
    /// public property of the total cost of the item the user has in the cart
    /// </summary>
    public decimal total
    {
        get
        {
            decimal num = 0;
            foreach(Item i in cart)
            {
                num += i.price;
            }
            return num;
        }
    }


    /// <summary>
    /// handles adding a given item into the cart
    /// </summary>
    /// <param name="item"></param>
	public void addItem(Item item)
	{
        cart.Add(item);
	}

    /// <summary>
    /// handles removing a given item from the cart
    /// </summary>
    /// <param name="item"></param>
	private void removeItem(Item item)
	{
        cart.Remove(item);
	}

    /// <summary>
    /// method for removing an item from the cart using its name as a string
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public decimal removeItemByName(string name)
    {
        Item item;
        foreach (Item i in cart)
        {
            if (i.name == name)
            {
                item = i;
                removeItem(i);
                return i.price;
            }
        }
        Console.WriteLine("There is no item " + name + " in the cart!");
        return 0;

    }

    /// <summary>
    /// prints out the content of the cart ( name and price )
    /// </summary>
    public void printCart()
    {
        foreach (Item i in cart)
        {
            Console.Write(i.name);
            for (int j = i.name.Length; j < 15; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("$" + i.price);
        }
    }


}

