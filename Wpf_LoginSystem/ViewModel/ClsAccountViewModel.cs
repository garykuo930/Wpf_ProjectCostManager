﻿using PMEntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_LoginSystem
{
    class ClsAccountViewModel
    {
        ProjectManagementEntities db = new ProjectManagementEntities();

        public void Register(string EmployeeID, string MemberID, string Password1, string Password2)
        {
            if (EmployeeID != "" && MemberID != "" && Password1 != "" && Password2 != "")
            {
                if (Password1 == Password2)
                {
                    List<Employee> employees = db.Employees.Where(p => p.EmployeeID == EmployeeID).ToList();
                    if (employees.Count != 0)
                    {
                        List<Member> members = db.Members.Where(p => p.EmployeeID == EmployeeID).ToList();
                        if (members.Count == 0)
                        {
                            Member member = new Member();
                            member.EmployeeID = EmployeeID;
                            member.MemberID = MemberID;
                            member.Password = Password1;
                            member.CreateDate = DateTime.Now;
                            member.ModifiedDate = DateTime.Now;
                            db.Members.Add(member);
                            try
                            {
                                db.SaveChanges();
                                MessageBox.Show("註冊成功!");
                            }
                            catch (Exception Exp)
                            {
                                MessageBox.Show(Exp.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("你已經註冊過了!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("此員工編號不存在!");
                    }
                }
                else
                {
                    MessageBox.Show("兩次輸入的密碼不同，請重新輸入");
                }
            }
            else
            {
                MessageBox.Show("請確認是否已填寫所有欄位");
            }
        }

        public bool Login(string MemberID, string Password)
        {
            List<Member> members = db.Members.Where(p => p.MemberID == MemberID && p.Password == Password).ToList();
            if (members.Count != 0)
            {
                members.First().LastLoginDate = DateTime.Now;
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("歡迎使用!");
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤");
                return false;
            }
        }

        public void ResetPassword(string EmployeeID, string MemberID, string Password1, string Password2)
        {
            if (EmployeeID != "" && MemberID != "" && Password1 != "" && Password2 != "")
            {
                if (Password1 == Password2)
                {
                    List<Member> members = db.Members.Where(p => p.EmployeeID == EmployeeID && p.MemberID == MemberID).ToList();
                    if (members.Count != 0)
                    {
                        Member member = members.First();
                        member.Password = Password1;
                        member.ModifiedDate = DateTime.Now;
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("修改成功!");
                        }
                        catch (Exception Exp)
                        {
                            MessageBox.Show(Exp.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("查無此會員!");
                    }
                }
                else
                {
                    MessageBox.Show("兩次輸入的密碼不同，請重新輸入");
                }
            }
            else
            {
                MessageBox.Show("請確認是否已填寫所有欄位");
            }
        }
    }
}
