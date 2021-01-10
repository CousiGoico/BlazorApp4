using System;
using BlazorApp4.Model;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp4.Pages
{
    public partial class Index: ComponentBase
    {
        public List<Column> Columns { get; set; }
        public List<Person> Data { get; set; }
        public List<ColumnAction> Actions { get; set; }

        protected override void OnInitialized()
        {
            Columns = new List<Column>() {
                new Column() { 
                    Title = "Identificador",
                    Order = 1,
                    Field ="Id",
                    Width = 250
                },
                new Column() {
                    Title = "Nombre",
                    Order = 2,
                    Field ="Name",
                    Width = 250
                },
                new Column() {
                    Title = "Apellido",
                    Order = 3,
                    Field ="Surname",
                    Width = 250
                },
                new Column() {
                    Title = "Edad",
                    Order = 4,
                    Field ="Age",
                    Width = 250
                }
            };

            Data = new List<Person>() {
                new Person() {
                    Id = 1,
                    Name ="Juan",
                    Surname = "Sanchez",
                    Age = 22
                },
                new Person() {
                    Id = 2,
                    Name ="Pepe",
                    Surname = "Lopez",
                    Age = 22
                },
                new Person() {
                    Id = 3,
                    Name ="Ana",
                    Surname = "Jimenez",
                    Age = 22
                },
                new Person() {
                    Id = 4,
                    Name ="Guillermo",
                    Surname = "Tevez",
                    Age = 22
                },
                new Person() {
                    Id = 5,
                    Name ="Jorge",
                    Surname = "Suarez",
                    Age = 22
                },
                new Person() {
                    Id = 6,
                    Name ="Luis",
                    Surname = "Perez",
                    Age = 22
                },
                new Person() {
                    Id = 1,
                    Name ="Juan",
                    Surname = "Sanchez",
                    Age = 22
                },
                new Person() {
                    Id = 2,
                    Name ="Pepe",
                    Surname = "Lopez",
                    Age = 22
                },
                new Person() {
                    Id = 3,
                    Name ="Ana",
                    Surname = "Jimenez",
                    Age = 22
                },
                new Person() {
                    Id = 4,
                    Name ="Guillermo",
                    Surname = "Tevez",
                    Age = 22
                },
                new Person() {
                    Id = 5,
                    Name ="Jorge",
                    Surname = "Suarez",
                    Age = 22
                },
                new Person() {
                    Id = 6,
                    Name ="Luis",
                    Surname = "Perez",
                    Age = 22
                },new Person() {
                    Id = 1,
                    Name ="Juan",
                    Surname = "Sanchez",
                    Age = 22
                },
                new Person() {
                    Id = 2,
                    Name ="Pepe",
                    Surname = "Lopez",
                    Age = 22
                },
                new Person() {
                    Id = 3,
                    Name ="Ana",
                    Surname = "Jimenez",
                    Age = 22
                },
                new Person() {
                    Id = 4,
                    Name ="Guillermo",
                    Surname = "Tevez",
                    Age = 22
                },
                new Person() {
                    Id = 5,
                    Name ="Jorge",
                    Surname = "Suarez",
                    Age = 22
                },
                new Person() {
                    Id = 6,
                    Name ="Luis",
                    Surname = "Perez",
                    Age = 22
                },
                new Person() {
                    Id = 1,
                    Name ="Juan",
                    Surname = "Sanchez",
                    Age = 22
                },
                new Person() {
                    Id = 2,
                    Name ="Pepe",
                    Surname = "Lopez",
                    Age = 22
                },
                new Person() {
                    Id = 3,
                    Name ="Ana",
                    Surname = "Jimenez",
                    Age = 22
                },
                new Person() {
                    Id = 4,
                    Name ="Guillermo",
                    Surname = "Tevez",
                    Age = 22
                },
                new Person() {
                    Id = 5,
                    Name ="Jorge",
                    Surname = "Suarez",
                    Age = 22
                },
                new Person() {
                    Id = 6,
                    Name ="Luis",
                    Surname = "Perez",
                    Age = 22
                }
            };

            Actions = new List<ColumnAction>() {
                new ColumnAction() {
                    Name="Edit",
                    Function = CreateDelegate<Person>(Edit),
                    Icon = "oi oi-pencil"
                },
                new ColumnAction() {
                    Name="Delete",
                    Function = CreateDelegate<Person>(Delete),
                    Icon = "oi oi-delete"
                }
            };
        }

        private void Edit(Person person) {
            Console.WriteLine($"Edit: {person.ToString()}");
        }

        private void Delete(Person person) {
            Console.WriteLine($"Delete: {person.ToString()}");
        }

        public static Action<T> CreateDelegate<T>(Action<T> action) => action;
    }
}
