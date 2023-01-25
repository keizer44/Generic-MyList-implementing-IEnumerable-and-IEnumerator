using System;
using System.Collections;
using System.Collections.Generic;

public class MyList<T> : IEnumerable<T>, IEnumerator<T>
{
    private List<T> items;
    private int currentIndex;

    public MyList()
    {
        this.items = new List<T>();
        this.currentIndex = -1;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.items.Count)
            {
                throw new IndexOutOfRangeException();
            }

            return items[index];
        }
        set
        {
            if (index < 0 || index >= this.items.Count)
            {
                throw new IndexOutOfRangeException();
            }

            items[index] = value;
        }
    }

    public int Count
    {
        get
        {
            return this.items.Count;
        }
    }

    public void Add(T item)
    {
        this.items.Add(item);
    }

    public void CLear()
    {
        this.items.Clear();
    }

    public bool Contains(T item)
    {
        return this.items.Contains(item);
    }

    public int IndexOF(T item)
    {
        return this.items.IndexOf(item);
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= this.items.Count)
        {
            throw new IndexOutOfRangeException();
        }

        this.items.RemoveAt(index);
    }

    public IEnumerator<T> GetEnumerator()
    {
        this.currentIndex = -1;

        return this;
    }

    public T Current
    {
        get
        {
            if(currentIndex < 0 || currentIndex>= this.items.Count)
            {
                throw new IndexOutOfRangeException();
            }

            return this.items[currentIndex];
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public bool MoveNext()
    {
        this.currentIndex++;

        if (currentIndex >= items.Count)
        {
            return false;
        }

        return true;
    }

    public void Reset()
    {
        this.currentIndex = -1;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Dispose()
    {

    }
}