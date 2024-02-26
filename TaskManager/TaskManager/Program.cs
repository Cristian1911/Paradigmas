using TaskManager;

Tarea tarea = new Tarea(CategoryList.Categories[0],"Pensar en los premios de las rifas pasadas",null,false,DateTime.Now);
Tarea tarea2 = new Tarea(CategoryList.Categories[0],"Evaluar talleres faltantes");
CategoryList.CreateCategory("Universidad");
Tarea tarea3 = new Tarea(CategoryList.Categories[1], "Evaluar talleres faltantes");
ToDoList tareas = new ToDoList("Universidad");
tareas.AddTask(tarea);
tareas.AddTask(tarea2);
tareas.DisplayTasks();
tareas.DisplayTasks(true);
tareas.DisplayTasks(false);
