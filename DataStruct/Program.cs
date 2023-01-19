// See https://aka.ms/new-console-template for more information

//Instancio Persona

Persona pki1 = new Persona("Kevin Jaramillo",
    "096","s","s", false);
Console.WriteLine(pki1.FullData());
public struct Persona
{
    public string NombreCompleto { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public bool NuevoCliente { get; set; }

    public Persona(string fullName, string phone, string address, string email, bool isNewClient)
    {
        NombreCompleto = fullName;
        Phone = phone;
        Address = address;
        Email = email;
        NuevoCliente = isNewClient;


    }

    public string FullData()
    {
        return "Me llamo " + NombreCompleto + " \n" +
            "Mi numero de telefono es " + Phone + "\n" +
            "Mi direccion es: " + Address + "\n" +
            "Mi email es: " + Email + " \n" +
            "Soy cliente nuevo?" + NuevoCliente;
    }
    


}


