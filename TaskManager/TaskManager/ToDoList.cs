using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class ToDoList
    {
        /*
        Clase lista de tareas.
        Category: el título de la lista (Casa, Universidad, Trabajo, etc)
        Tareas: Lista de tareas asociada la categoría.
        */
        public string Category;
        private List<Tarea> Tareas;
        public ToDoList(string category) 
        {
            this.Category = category;
            Tareas = new List<Tarea>();
        }
        public void AddTask(Tarea tarea)
        {
            Tareas.Add(tarea);
        }
        public void DisplayTasks()
        {
            Console.WriteLine($"Estas son las tareas que tienes actualmente en tu lista de {Category}:\n");
            for (int i = 0; i < Tareas.Count; i++)
            {
                Console.WriteLine($"{Tareas[i].ShowDetails(i)}");
            }
        }

        public void DisplayTasks(bool isCompleted)
        {
            string tipoTarea = isCompleted ? "completadas" : "pendientes";
            Console.WriteLine($"Estas son las tareas {tipoTarea} que tienes actualmente en tu lista de {Category}:\n");
            for (int i = 0; i < Tareas.Count; i++)
            {
                if (Tareas[i].IsCompleted == isCompleted)
                {
                    Console.WriteLine($"{Tareas[i].ShowDetails(i)}");
                }
            }
        }
    }
}
