using System;
using System.Collections.Generic;
/* Modificacion ddel codigo
   que hizo el maestro.
   Jualy Fabre 2025-1896
 */
class AgendaPersonal
{
    static void Main(string[] args)
    {


        Console.WriteLine("Bienvenido a mi lista de Contactes");


        //names, lastnames, addresses, telephones, emails, ages, bestfriend
        bool runing = true;
        List<int> ids = new List<int>();
        Dictionary<int, string> names = new Dictionary<int, string>();
        Dictionary<int, string> lastnames = new Dictionary<int, string>();
        Dictionary<int, string> addresses = new Dictionary<int, string>();
        Dictionary<int, string> telephones = new Dictionary<int, string>();
        Dictionary<int, string> emails = new Dictionary<int, string>();
        Dictionary<int, int> ages = new Dictionary<int, int>();
        Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();


        while (runing)
        {
            Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   6. Eliminar Contacto    6. Salir");
            Console.WriteLine("Digite el número de la opción deseada");

            int typeOption = Convert.ToInt32(Console.ReadLine());

            switch (typeOption)
            {
                case 1:
                    {
                        //Console.WriteLine("Digite el nombre de la persona");
                        //string name = Console.ReadLine();
                        //Console.WriteLine("Digite el apellido de la persona");
                        //string lastname = Console.ReadLine();
                        //Console.WriteLine("Digite la dirección");
                        //string address = Console.ReadLine();
                        //Console.WriteLine("Digite el telefono de la persona");
                        //string phone = Console.ReadLine();
                        //Console.WriteLine("Digite el email de la persona");
                        //string email = Console.ReadLine();
                        //Console.WriteLine("Digite la edad de la persona en números");
                        //int age = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
                        ////var temp = Convert.ToInt32(Console.ReadLine());
                        ////bool isBestFriend;
                        ////if (temp == 1)
                        ////{ isBestFriend = true; }
                        ////else
                        ////{ isBestFriend = false; }
                        //bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

                        //var id = ids.Count + 1;
                        //ids.Add(id);
                        //names.Add(id, name);
                        //lastnames.Add(id, lastname);
                        //addresses.Add(id, address);
                        //telephones.Add(id, phone);
                        //emails.Add(id, email);
                        //ages.Add(id, age);
                        //bestFriends.Add(id, isBestFriend);

                        AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);

                    }
                    break;
                case 2: //extract this to a method
                    {
                        Console.WriteLine($"Nombre       Apellido         Dirección        Telefono         Email        Edad         Es Mejor Amigo?");
                        Console.WriteLine($"____________________________________________________________________________________________________________________________");
                        foreach (var id in ids)
                        {
                            var isBestFriend = bestFriends[id];

                            //string isBestFriendStr;

                            //if (isBestFriend == true)
                            //{
                            //    isBestFriendStr = "Si";
                            //}
                            //else {
                            //    isBestFriendStr = "No";
                            //}

                            string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
                            Console.WriteLine($"{names[id]}           {lastnames[id]}            {addresses[id]}            {telephones[id]}               {emails[id]}              {ages[id]}            {isBestFriendStr}");
                        }

                    }
                    break;
                case 3: //search
                    {
                        SearchContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                        break;
                    }
                    break;
                case 4: //modify
                    {
                        ModifyContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                        break;
                    }
                    break;
                case 5: //delete
                    {
                        DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                        break;
                    }
                    break;
                case 6:
                    runing = false;
                    break;
                default:
                    Console.WriteLine("Tu eres o te haces el idiota?");
                    break;
            }
        }


        static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
        {
            Console.WriteLine("Digite el nombre de la persona");
            string name = Console.ReadLine();
            Console.WriteLine("Digite el apellido de la persona");
            string lastname = Console.ReadLine();
            Console.WriteLine("Digite la dirección");
            string address = Console.ReadLine();
            Console.WriteLine("Digite el telefono de la persona");
            string phone = Console.ReadLine();
            Console.WriteLine("Digite el email de la persona");
            string email = Console.ReadLine();
            Console.WriteLine("Digite la edad de la persona en números");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");

            bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

            var id = ids.Count + 1;
            ids.Add(id);
            names.Add(id, name);
            lastnames.Add(id, lastname);
            addresses.Add(id, address);
            telephones.Add(id, phone);
            emails.Add(id, email);
            ages.Add(id, age);
            bestFriends.Add(id, isBestFriend);
        }

        {
            Console.WriteLine("Digite el nombre de la persona");
            string name = Console.ReadLine();

            Console.WriteLine("Digite el apellido de la persona");
            string lastname = Console.ReadLine();

            Console.WriteLine("Digite la dirección");
            string address = Console.ReadLine();

            Console.WriteLine("Digite el teléfono de la persona");
            string phone = Console.ReadLine();

            Console.WriteLine("Digite el email de la persona");
            string email = Console.ReadLine();

            Console.WriteLine("Digite la edad de la persona en números");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
            bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

            int id = ids.Count + 1;
            ids.Add(id);
            names.Add(id, name);
            lastnames.Add(id, lastname);
            addresses.Add(id, address);
            telephones.Add(id, phone);
            emails.Add(id, email);
            ages.Add(id, age);
            bestFriends.Add(id, isBestFriend);

            Console.WriteLine($" Contacto '{name} {lastname}' agregado con éxito.");
        }

        // ─────────────────────────────────────────────

        static void ShowContacts(
            List<int> ids,
            Dictionary<int, string> names,
            Dictionary<int, string> lastnames,
            Dictionary<int, string> addresses,
            Dictionary<int, string> telephones,
            Dictionary<int, string> emails,
            Dictionary<int, int> ages,
            Dictionary<int, bool> bestFriends)
        {
            if (ids.Count == 0)
            {
                Console.WriteLine("No hay contactos registrados.");
                return;
            }

            Console.WriteLine($"\n{"ID",-5} {"Nombre",-15} {"Apellido",-15} {"Dirección",-20} {"Teléfono",-15} {"Email",-25} {"Edad",-6} {"Mejor Amigo"}");
            Console.WriteLine(new string('─', 105));

            foreach (var id in ids)
            {
                string isBestFriendStr = bestFriends[id] ? "Sí" : "No";
                Console.WriteLine($"{id,-5} {names[id],-15} {lastnames[id],-15} {addresses[id],-20} {telephones[id],-15} {emails[id],-25} {ages[id],-6} {isBestFriendStr}");
            }
        }

        // ─────────────────────────────────────────────

        static void SearchContact(
            List<int> ids,
            Dictionary<int, string> names,
            Dictionary<int, string> lastnames,
            Dictionary<int, string> addresses,
            Dictionary<int, string> telephones,
            Dictionary<int, string> emails,
            Dictionary<int, int> ages,
            Dictionary<int, bool> bestFriends)
        {
            Console.WriteLine("Digite el nombre o apellido a buscar");
            string query = Console.ReadLine().ToLower();

            bool found = false;

            Console.WriteLine($"\n{"ID",-5} {"Nombre",-15} {"Apellido",-15} {"Dirección",-20} {"Teléfono",-15} {"Email",-25} {"Edad",-6} {"Mejor Amigo"}");
            Console.WriteLine(new string('─', 105));

            foreach (var id in ids)
            {
                // Busca si el query coincide con nombre O apellido
                if (names[id].ToLower().Contains(query) || lastnames[id].ToLower().Contains(query))
                {
                    string isBestFriendStr = bestFriends[id] ? "Sí" : "No";
                    Console.WriteLine($"{id,-5} {names[id],-15} {lastnames[id],-15} {addresses[id],-20} {telephones[id],-15} {emails[id],-25} {ages[id],-6} {isBestFriendStr}");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No se encontró ningún contacto con ese nombre o apellido.");
        }

        // ─────────────────────────────────────────────

        static void ModifyContact(
            List<int> ids,
            Dictionary<int, string> names,
            Dictionary<int, string> lastnames,
            Dictionary<int, string> addresses,
            Dictionary<int, string> telephones,
            Dictionary<int, string> emails,
            Dictionary<int, int> ages,
            Dictionary<int, bool> bestFriends)
        {
            Console.WriteLine("Digite el ID del contacto a modificar");
            int id = Convert.ToInt32(Console.ReadLine());

            if (!ids.Contains(id))
            {
                Console.WriteLine("No existe un contacto con ese ID.");
                return;
            }

            Console.WriteLine($"Modificando a: {names[id]} {lastnames[id]}");
            Console.WriteLine("Presione ENTER para conservar el valor actual.\n");

            Console.Write($"Nombre [{names[id]}]: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) names[id] = input;

            Console.Write($"Apellido [{lastnames[id]}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) lastnames[id] = input;

            Console.Write($"Dirección [{addresses[id]}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) addresses[id] = input;

            Console.Write($"Teléfono [{telephones[id]}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) telephones[id] = input;

            Console.Write($"Email [{emails[id]}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) emails[id] = input;

            Console.Write($"Edad [{ages[id]}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) ages[id] = Convert.ToInt32(input);

            Console.Write($"¿Es mejor amigo? (1. Sí / 2. No) [{(bestFriends[id] ? "Sí" : "No")}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) bestFriends[id] = input == "1";

            Console.WriteLine(" Contacto modificado con éxito.");
        }

        // ─────────────────────────────────────────────

        static void DeleteContact(
            List<int> ids,
            Dictionary<int, string> names,
            Dictionary<int, string> lastnames,
            Dictionary<int, string> addresses,
            Dictionary<int, string> telephones,
            Dictionary<int, string> emails,
            Dictionary<int, int> ages,
            Dictionary<int, bool> bestFriends)
        {
            Console.WriteLine("Digite el ID del contacto a eliminar");
            int id = Convert.ToInt32(Console.ReadLine());

            if (!ids.Contains(id))
            {
                Console.WriteLine("No existe un contacto con ese ID.");
                return;
            }

            Console.WriteLine($"¿Seguro que desea eliminar a {names[id]} {lastnames[id]}? (1. Sí / 2. No)");
            int confirm = Convert.ToInt32(Console.ReadLine());

            if (confirm == 1)
            {
                ids.Remove(id);
                names.Remove(id);
                lastnames.Remove(id);
                addresses.Remove(id);
                telephones.Remove(id);
                emails.Remove(id);
                ages.Remove(id);
                bestFriends.Remove(id);

                Console.WriteLine(" Contacto eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Operación cancelada.");
            }
        }
    }
}