using Livraria.Models;
Funcionario funcionario = new Funcionario("João", "Pedro", "cpf", 21, "user", "senha");
Estoque estoque = new Estoque();
List<Cliente> clientes = new List<Cliente>();
estoque.CadastroInicial();


estoque.ConsultarEstoque();

//bool checkLogin;
//do
//{
//    checkLogin = Sistema.RealizarLogin(funcionario);

//} while (checkLogin == false);

//int input;
//do
//{
//    input = Sistema.Menu();

//    switch (input)
//    {
//        case 0:
//            break;
//        case 1:
//            Cliente cliente = Sistema.RegistrarCliente();
//            clientes.Add(cliente);
//            break;
//        case 2:
//            estoque.RegistrarProduto();
//            break;
//        case 3:
//            //estoque.RealizarVenda(clientes);
//            break;
//        case 4:
//            estoque.ConsultarEstoque();
//            break;
//    }
//} while (input != 0);



//MENU
//CadastrarCliente
//CadastrarIProduto
//RealizarVenda
//ConsultarEstoque
