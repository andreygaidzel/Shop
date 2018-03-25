using System.Collections.Generic;
using Shop.DAL.Models;

namespace Shop.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Shop.DAL.ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Shop.DAL.ShopContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.Add(new Category
                {
                    Name = "����",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "����� � �����",
                    SubCategories = new List<SubCategory>
                   {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "������� �������",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "��� ��� ����� � �������",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "������� ���",
                    SubCategories = new List<SubCategory>
                     {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "��� � ����",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "����� � �����",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "����������",
                    SubCategories = new List<SubCategory>
                     {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "������� � ��������",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "������ � ��������",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "������ � ����������",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "����� � ������",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "������������� � ������",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "���������",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "���� � �����������",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "����� � �������",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "���� � �����",
                        },
                        new SubCategory
                        {
                            Name = "������������� �����������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������������"},
                                new SubSubCategory {Name = "������������"},
                                new SubSubCategory {Name = "�����������������"},
                                new SubSubCategory {Name = "GPS-����������"},
                                new SubSubCategory {Name = "����������������"},
                                new SubSubCategory {Name = "��������� ����� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "������������ �������������"},
                                new SubSubCategory {Name = "���������"},
                                new SubSubCategory {Name = "��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���������� ��� ����",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "��������"},
                                new SubSubCategory {Name = "������ �������������"},
                                new SubSubCategory {Name = "������������� ����� � �������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "���� � ������������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�����-�������� ����������"},
                                new SubSubCategory {Name = "����� �������� ��������"},
                                new SubSubCategory {Name = "����������� �������������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������������� ����� � ��������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "����� ��������"},
                                new SubSubCategory {Name = "�������������� � �������������� ��������"},
                                new SubSubCategory {Name = "����������� ��������"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "������ � �������� �������",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "�������� ������� ������"},
                                new SubSubCategory {Name = "�������� ��������� ��� �����������"},
                                new SubSubCategory {Name = "��������� �� ����� ����������"},
                            }
                        },
                        new SubCategory {Name = "�����������"},
                        new SubCategory {Name = "������� ����������"}
                    }
                });
            }
        }
    }
}
