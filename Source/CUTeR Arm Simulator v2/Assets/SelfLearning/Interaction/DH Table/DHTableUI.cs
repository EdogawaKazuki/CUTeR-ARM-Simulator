using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using Unity.VisualScripting;
using System.Linq;
using TMPro; // Only needed in Editor for preview

public class DHTableUI : MonoBehaviour
{
    [SerializeField] private List<DHRowData> dhParameters = new List<DHRowData>();
    [SerializeField] private bool userWritable = false;


    private UnityEngine.UI.Button quitButton;
    private List<GameObject> rows = new();

    public int previous_selected_index = -1;

    void Start()
    {

        quitButton = transform.Find("Menu/QuitButton").GetComponent<UnityEngine.UI.Button>();


        // addButton?.RegisterCallback<ClickEvent>(evt => AddNewRow());
        // removeButton?.RegisterCallback<ClickEvent>(evt => RemoveRow());
        Debug.Log("Debug Line 1:" + quitButton.name);
        quitButton.onClick.AddListener(() => { DisableDHTable(); });
        
        RefreshTable();
    }

    private void RefreshTable()
    {
        AlignRows();
        for (int i = 0; i < dhParameters.Count; i++)
            UpdateRow(i, dhParameters[i]);
    }
    private void AlignRows()
    {
        if (rows.Count < dhParameters.Count)
        {
            while (rows.Count < dhParameters.Count)
            {
                AddNewRow();
            }
        }
        else if (rows.Count > dhParameters.Count)
        {
            while (rows.Count > dhParameters.Count)
            {
                RemoveRow();
            }
        }
    }
    
    private void UpdateRow(int index, DHRowData parameter)
    {
        if (index < 0 || index >= rows.Count) return;

        var row = rows[index];
        row.transform.Find("theta").GetComponent<TextMeshProUGUI>().text = parameter.Theta.ToString();
        row.transform.Find("d").GetComponent<TextMeshProUGUI>().text = parameter.D.ToString();        
        row.transform.Find("alpha").GetComponent<TextMeshProUGUI>().text = parameter.Alpha.ToString();        
        row.transform.Find("a").GetComponent<TextMeshProUGUI>().text = parameter.A.ToString();        

    }



    public void AddNewRow(int branch_index=-1)
    {
        int i = rows.Count + 1;
        // Duplicate the template GameObject and rename it to "Row i"
        var template = GameObject.Find("Menu/Panel/Template");
        if (template != null)
        {
            var newRow = Instantiate(template, template.transform.parent);
            newRow.name = $"Row {i}";
            newRow.SetActive(true);
            if (branch_index == -1)
                branch_index = rows.Count;
            var uiButton = newRow.GetComponent<UnityEngine.UI.Button>();
            if (uiButton != null)
            {
                uiButton.onClick.AddListener(() => { previous_selected_index = branch_index; });
            }
            rows.Add(newRow);


        }
        else
        {
            Debug.LogError("Template GameObject not found at path: Menu/Panel/Template");
        }
    }

    public void RemoveRow(int index=-1)
    {
        if (index == -1)
            index = rows.Count - 1;
        Destroy(rows[index]);
        rows.RemoveAt(index);


    }

    public List<DHRowData> GetDHParameters() => new List<DHRowData>(dhParameters);

    public void SetDHParameters(List<DHRowData> parameters)
    {
        dhParameters = parameters ?? new List<DHRowData>();
        RefreshTable();
    }

    public void DisableDHTable()
    {
        this.gameObject.SetActive(false);
        previous_selected_index = -2;
    }
    private void OnDisable()
    {

    }
}