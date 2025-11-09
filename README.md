
# Consumo de APIs com .NET

Em aplicações mais simples, a classe HttpClient é usada para navegar por APIs e enviar/receber dados.

## Classes usadas

#### HttpClient
Usada para receber/enviar dados para uma API web definida pela URI na propriedade BaseAddress.

#### Pokemon
Classe para representar os dados com os quais estamos trabalhando (no caso da PokeAPI, Pokemons).

## Métodos importantes

#### HttpClient.GetAsync(String)
Faz uma requisição GET no caminho que passarmos como argumento (ex: "api/products") e gera um HttpResponseMessage com a resposta.

#### HttpClient.DefaultRequestHeaders.Accept.Clear()
Retira todos os cabeçalhos de Accept gerados automaticamente pelo .NET

#### HttpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue)
Adiciona um cabeçalho de Accept personalizado ao HttpClient (todas as requisições terão este cabeçalho)

#### HttpResponseMessage.Content.ReadAsAsync<T>()
Converte o conteúdo da resposta HTTP em um objeto da classe especificada em T