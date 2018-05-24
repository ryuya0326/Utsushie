using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager{
    //static
    static ItemManager m_instance = null;

    //Item数
    const int ItemNum= 0;
    int m_Item = ItemNum;

    public static ItemManager Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = new ItemManager();
            }
            return m_instance;
        }
    }
    public int Itemnum
    {
        get { return m_Item; } 
        set { m_Item = value; }
    }
}