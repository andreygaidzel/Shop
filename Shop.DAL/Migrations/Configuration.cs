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
                    Name = "Авто",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Аудио и видео",
                    SubCategories = new List<SubCategory>
                   {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Бытовая техника",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Все для офиса и бизнеса",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Детский мир",
                    SubCategories = new List<SubCategory>
                     {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Дом и дача",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Досуг и хобби",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Компьютеры",
                    SubCategories = new List<SubCategory>
                     {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Красота и здоровье",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Мебель и интерьер",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Одежда и аксессуары",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Спорт и туризм",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Строительство и ремонт",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Телефония",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Фото и видеокамеры",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });

                context.Categories.Add(new Category
                {
                    Name = "Цветы и подарки",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Шины и диски",
                        },
                        new SubCategory
                        {
                            Name = "Автомобильная электроника",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Автомагнитолы"},
                                new SubSubCategory {Name = "Автоакустика"},
                                new SubSubCategory {Name = "Видеорегистраторы"},
                                new SubSubCategory {Name = "GPS-навигаторы"},
                                new SubSubCategory {Name = "Автосигнализации"},
                                new SubSubCategory {Name = "Усилители звука автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автозапчасти",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Аккумуляторы автомобильные"},
                                new SubSubCategory {Name = "Двигатель"},
                                new SubSubCategory {Name = "Подвеска"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Аксессуары для авто",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Домкраты"},
                                new SubSubCategory {Name = "Антены автомобильные"},
                                new SubSubCategory {Name = "Автомобильные чехлы и накидки"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Уход и обслуживание",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Пуско-зарядные устройства"},
                                new SubSubCategory {Name = "Мойка высокого давления"},
                                new SubSubCategory {Name = "Компрессоры автомобильные"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Автомобильные масла и жидкости",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Масла моторные"},
                                new SubSubCategory {Name = "Трансмисионные и гидравлические жидкости"},
                                new SubSubCategory {Name = "Охлаждающие жидкости"},
                            }
                        },
                        new SubCategory
                        {
                            Name = "Пицепы и багажные системы",
                            SubSubCategories = new List<SubSubCategory>
                            {
                                new SubSubCategory {Name = "Багажные системы прочие"},
                                new SubSubCategory {Name = "Багажные крепления для велосипедов"},
                                new SubSubCategory {Name = "Автобоксы на крышу автомобиля"},
                            }
                        },
                        new SubCategory {Name = "Мототехника"},
                        new SubCategory {Name = "Детские автокресла"}
                    }
                });
            }
        }
    }
}
