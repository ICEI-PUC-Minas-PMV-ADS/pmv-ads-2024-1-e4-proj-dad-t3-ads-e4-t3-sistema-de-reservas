import Head from 'next/head';

export default function Login() {
  return (
    <div>
      <Head>
        <title >Reservas: Login</title>
        <link rel="icon" href="/favicon.ico" />
      </Head>
      <div class="h-screen bg-gray-200 py-20 p-4 md:p-20 lg:p-32">
    <div class="max-w-sm bg-white rounded-lg overflow-hidden shadow-lg mx-auto">
        <div class="p-6">
            <h2 class="text-2xl font-bold text-gray-800 mb-2">Sistema de Reservas</h2>
            <form>
                <div class="mb-4">
                    <label class="block text-gray-700 font-bold mb-2" for="username">
            E-mail
          </label>
                    <input class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" id="username" type="text" placeholder="Digite seu e-mail"/>
                </div>
                <div class="mb-6">
                    <label class="block text-gray-700 font-bold mb-2" for="password">
            Senha
          </label>
                    <input class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" id="password" type="password" placeholder="Digite sua enha"/>
                </div>
                <div class="flex items-center justify-between">
                    <button class="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline" type="button">
            Entrar
          </button>
                    <a class="inline-block align-baseline font-bold text-sm text-blue-500 hover:text-blue-800" href="#">
                        Esqueceu a senha?
                    </a>
                </div>
            </form>
        </div>
    </div>
    </div>
    </div>
  );
}
