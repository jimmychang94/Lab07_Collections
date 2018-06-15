using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Deck<T> : IEnumerable
    {
        // Here we initialize the deck with an array of size 5
        T[] items = new T[5];

        // This starts a counter for how many elements we have in the collection
        int count;

        /// <summary>
        /// This finds the allocated space that the array uses.
        /// </summary>
        /// <returns>The length of the array</returns>
        public int DetermineLength()
        {
            return items.Length;
        }

        /// <summary>
        /// This finds the number of elements in the array
        /// </summary>
        /// <returns>The number of elements in the array</returns>
        public int Length()
        {
            return count;
        }

        // Add Method
        /// <summary>
        /// This method adds a T type item to this collection
        /// </summary>
        /// <param name="item">A T type item to add to the collection</param>
        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }

            items[count++] = item;
        }

        /// <summary>
        /// This method removes an item at the index given from the collection
        /// </summary>
        /// <param name="index">The index of the item you want to remove</param>
        /// <returns>A True or False on whether a card was removed</returns>
        public bool Remove(int index)
        {
            if (count < items.Length / 2)
            {
                Array.Resize(ref items, items.Length / 2);
            }

            if (index < 0)
            {
                return false;
            }
            int i;
            for (i = 0 ; i < count; i++)
            {
                if (i >= index)
                {
                    items[i] = items[i + 1];
                }
            }
            if (index > i)
            {
                return false;
            }
            count--;
            return true;
        }

        /// <summary>
        /// This method shuffles the deck.
        /// </summary>
        public void Shuffle()
        {
            T[] shuffled = new T[items.Length];
            int[] randomIndex = new int[count];
            for (int i = 0; i < randomIndex.Length; i ++)
            {
                randomIndex[i] = -1;
            }
            for (int j = 0; j < randomIndex.Length; j++)
            {
                int randNum = RandomNumberGenerator();
                while (Array.IndexOf(randomIndex, randNum) != -1)
                {
                    randNum = RandomNumberGenerator();
                }
                randomIndex[j] = randNum;
            }
            for (int k = 0; k < randomIndex.Length; k++)
            {
                shuffled[k] = items[randomIndex[k]];
            }
            items = shuffled;
        }

        /// <summary>
        /// This creates a random number from 0 to the number of elements in the collection
        /// </summary>
        /// <returns>A random number</returns>
        public int RandomNumberGenerator()
        {
            Random range = new Random();
            int value = range.Next(0, count);
            return value;
        }

        /// <summary>
        /// This finds the item located at the index given
        /// </summary>
        /// <param name="index">The index of the item you want</param>
        /// <returns>The item located at the index provided</returns>
        public T Find(int index)
        {
            return items[index];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        // Magic DON'T TOUCH
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
