﻿/******************************************************************************************************************************************************
 江西联创精密机电有限公司对本代码拥有全部权限，未经许可不得引用本代码任何内容，也不得用于非江西联创精密机电有限公司之外的任何商业和非商业项目。

 项目编号：
 软件名称：

 开发环境：
 运行环境：
 功能描述：

 原作者：邓通福
 完成日期：
 特别说明：

 修改者：
 完成日期：
 修改记录：
 如经过多次修改，则继续往下添加。
 **********************************************************************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoubleClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] NodeInfo3D;
    public float Interval = 0.5f;
    private float m_fFirstClicked = 0;
    private float m_fSecondClicked = 0;
    
    public void OnDBClick(int i)
    {
        m_fSecondClicked = Time.realtimeSinceStartup;
        if (m_fSecondClicked - m_fFirstClicked < Interval)
        {
            NodeInfo3D[i].SetActive(true);
            StartCoroutine(Delay10(i));
        }
        else
        {
            m_fFirstClicked = m_fSecondClicked;
        }
    }
    public void OnDoubleClicked()
    {
        this.OnDBClick(0);
    }
    public void OnDoubleClicked1()
    {
        this.OnDBClick(1);
    }
    public void OnDoubleClicked2()
    {
        this.OnDBClick(2);
    }
    public void OnDoubleClicked3()
    {
        this.OnDBClick(3);
    }
    public void OnDoubleClickedAll()
    {
        m_fSecondClicked = Time.realtimeSinceStartup;
        if (m_fSecondClicked - m_fFirstClicked < Interval)
        {
            for (int i = 0; i < NodeInfo3D.Length; i++)
            {
                NodeInfo3D[i].SetActive(true);
                StartCoroutine(Delay10(i));
            }
           
        }
        else
        {
            m_fFirstClicked = m_fSecondClicked;
        }
    }
    IEnumerator Delay10(int i )
    {
        yield return new WaitForSeconds(10);
       
            NodeInfo3D[i].SetActive(false);
     
    }
}
