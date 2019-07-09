using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tab_menu;
using System.Security.Cryptography;

namespace tab_menu
{
    class ading
    {
        
            
                public bool login_user(string email, string password)
                {
                    using (var db = new Model.Context())
                    {

                        var res = db.users.Where(i => i.Email == email && i.Pass == password).FirstOrDefault();
                        //if (res==null)
                        //{
                        //    res=db.masters.Where(i=>i.Email==email && i.Pass==password)
                        //}

                        var query = from e in db.users
                                    where e.Email == email
                                    select e;
                        db.SaveChanges();
                        try
                        {

                            if (res != null)
                            {

                                foreach (var item in query)
                                {
                                    Console.WriteLine("hello" + item.FullName + "    welcome");
                                }

                            }
                            return true;
                        }

                        catch (Exception ex)
                        {

                            Console.WriteLine("your pass is wrong");
                            // MessageBox.Show(ex.Message);
                            return false;
                        }

                    }
                }



                public bool Signup(string first, string last, string email, string password, string confirm_password, bool ismaster)
                {
                    using (var db = new Model.Context())
                    {
                        string hashpass = GetHashString(password);
                        try
                        {
                            if (password == confirm_password)
                            {

                                if (ismaster == true)
                                {
                                    db.masters.Add(new Model.Master { IsMaster = true, Email = email, Name = first, LastName = last, Pass = hashpass });
                                }
                                else
                                {
                                    db.users.Add(new Model.User { Name = first, LastName = last, Email = email, Pass = hashpass });

                                }
                                db.SaveChanges();

                            }
                            return true;
                        }
                        catch (Exception)
                        {
                            // MessageBox.Show("your pass is wrong");
                            return false;
                        }

                    }

                }


                public bool AddProduct(string name, string money, string color, string gender, string shelf, string weghit)
                {
                    int check = userid();
                    using (var db = new Model.Context())
                    {
                        try
                        {
                            db.products.Add(new Model.Product { Name = name, money = money, Color = color, IsExist = true, Gender = gender, Shelf = shelf, Weight = weghit, userID = check });
                            db.SaveChanges();
                            return true;
                        }
                        catch (Exception e)
                        {

                            throw new Exception();
                        }


                    }
                }



                public static byte[] GetHash(string inputString)
                {
                    HashAlgorithm algorithm = SHA256.Create();
                    return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
                }

                public static string GetHashString(string inputString)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in GetHash(inputString))
                        sb.Append(b.ToString("X2"));

                    return sb.ToString();
                }


                public int userid()
                {
                    Random rn = new Random();
                    int check = rn.Next();
                    return check;


                }



                public bool login_master(string email, string password)
                {
                    using (var db = new Model.Context())
                    {

                        var res = db.masters.Where(i => i.Email == email && i.Pass == password).FirstOrDefault();
                        var query = from e in db.users
                                    where e.Email == email
                                    select e;
                        db.SaveChanges();
                        try
                        {

                            if (res != null)
                            {

                                foreach (var item in query)
                                {
                                    Console.WriteLine("hello" + item.FullName + "    welcome");
                                }

                            }
                            return true;
                        }

                        catch (Exception ex)
                        {

                            Console.WriteLine("your pass is wrong");
                            return false;
                        }

                    }
                }
            }
}
