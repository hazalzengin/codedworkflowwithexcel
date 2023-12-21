using excelwithcoding.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace excelwithcoding
{
    public class Workflow : CodedWorkflow
    {
      
        [Workflow]
        public void Execute(DataTable readDBtable, DataTable DBtable, DataTable db2table)
        {
           
        foreach (DataRow row in readDBtable.Rows){
           var g_adi=(row["Gönderici Adı"].ToString());
          var a= (row["Belge numarası"].ToString());
             var b= (row["Belge numarası_1"].ToString());
            var newpara_1="";
            var c= (row["Gönderici VKN/TCKN"].ToString());
             Log(c);
            var d= (row["Karakter 1"].ToString());
       
            var e= (row["ID"].ToString());
            var g= (row["Ödenebilir Miktar"].ToString());
            var para_birimi= (row["Belge para birimi değeri"].ToString());
             var para_birimi_anahtar= (row["Belge para birimi anahtarı"].ToString());
             var kod_p_birimi= (row["Şirket kodu para birimi değeri"].ToString());
             var kod_p_a= (row["Şirket kodu para birimi anahtarı"].ToString());
             var k_adi= (row["Kullanıcı adı"].ToString());
             var p_birimi_1= (row["Para birimi_1"].ToString());
            if(para_birimi.Contains("-")){
                newpara_1=para_birimi.Replace("-","");
            } 
             
                if (g==newpara_1){
                    Log("Para birimi eşit");
                    DBtable.Rows.Add("eşit");
                }
                else{
                   
                    Log("para birimi eşit değil");
                     DBtable.Rows.Add("para birimi eşit değil");
                }
              
                     var f= (row["SAP Belge Tarihi"].ToString());
            
            var h= (row["Para Birimi"].ToString());
            var i= (row["İş Alanı"].ToString());
           var k= (row["Kâr merkezi (FI)"].ToString());
            var fatura_sahibi= (row["Fatura Sahibi"].ToString());
            var m= (row["Ad"].ToString()); 
            var n= (row["Ana hesap"].ToString());
             var o= (row["Belge türü"].ToString());
              var referans= (row["Referans"].ToString());
            var tarih= (row["Belge tarihi"].ToString());
                    
                       if (f==tarih){
                    Log("Tarih birimi eşit");
                           db2table.Rows.Add("TARİH birimi eşit");
                   
                }
                else{
                    Log(" tarih eşit değil");
                     db2table.Rows.Add("TARİH birimi eşit DEĞİL");
                  
                }
                                
            }
        }
    }
}