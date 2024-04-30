import Head from 'next/head';

import { Button } from "@/components/ui/button"
import {
  Card,
  CardContent,
  CardDescription,
  CardFooter,
  CardHeader,
  CardTitle,
} from "@/components/ui/card"
import { Input } from "@/components/ui/input"
import { Label } from "@/components/ui/label"
import {
  Tabs,
  TabsContent,
  TabsList,
  TabsTrigger,
} from "@/components/ui/tabs"

export default function Registro() {
  return (
    <Tabs defaultValue="Condomino" className="h-screen flex items-center text-center justify-center bg-gray-200 py-20 p-4 md:p-20 lg:w-full lg:p-32">
      <div className='lg:w-1/4'>

      <TabsList className="grid w-full grid-cols-2 w-full shadow-md">
        <TabsTrigger value="Condomino">Condômino</TabsTrigger>
        <TabsTrigger value="Condominio">Password</TabsTrigger>
      </TabsList>
      <TabsContent value="Condomino" className='w-full shadow-md'>
        <Card>
          <CardHeader>
            <CardTitle>Condômino</CardTitle>
            <CardDescription>
              Se registre como um Condomino
            </CardDescription>
          </CardHeader>
          <CardContent className="space-y-2">
            <div className="space-y-1 mb-4">
              <Label className="flex text-left" htmlFor="name">Nome</Label>
              <Input id="name" placeholder="Informe o seu nome" />
            </div>
            <div className="space-y-1 mb-4">
              <Label className="flex text-left" htmlFor="email">E-mail</Label>
              <Input id="email" placeholder="Informe o seu e-mail" />
            </div>
            <div className="space-y-1 mb-4">
              <Label className="flex text-left" htmlFor="cpf">CPF</Label>
              <Input id="cpf" placeholder="Informe o seu CPF" />
            </div>
            <div className="space-y-1 mb-4">
              <Label className="flex text-left" htmlFor="password">Senha</Label>
              <Input id="name" placeholder="Digite uma senha" />
            </div>
            <div className="space-y-1 mb-4">
              <Label className="flex text-left" htmlFor="confirmPassword">Confirmação de senha</Label>
              <Input id="confirmPassword" placeholder="Confirme sua senha" />
            </div>
          </CardContent>
          <CardFooter>
            <Button>Criar nova conta</Button>
          </CardFooter>
        </Card>
      </TabsContent>
      <TabsContent value="Condominio" className='shadow-md'>
      <Card>
          <CardHeader>
            <CardTitle>Condomínio</CardTitle>
            <CardDescription>
              Se registre como um Condomínio
            </CardDescription>
          </CardHeader>
          <CardContent className="space-y-2">
            <div className="space-y-1 mb-4">
              <Label className="flex text-left" htmlFor="name">Nome</Label>
              <Input id="name" placeholder="Informe o seu nome" />
            </div>
            <div className="space-y-1 mb-4">
              <Label className="flex text-left" htmlFor="email">E-mail</Label>
              <Input id="email" placeholder="Informe o seu e-mail" />
            </div>
            <div className="space-y-1 mb-4">
              <Label className="flex text-left" htmlFor="cnpj">CNPJ</Label>
              <Input id="cnpj" placeholder="Informe o seu CNPJ" />
            </div>
            <div className="space-y-1 mb-4">
              <Label className="flex text-left" htmlFor="password">Senha</Label>
              <Input id="name" placeholder="Digite uma senha" />
            </div>
            <div className="space-y-1 mb-4">
              <Label className="flex text-left" htmlFor="confirmPassword">Confirmação de senha</Label>
              <Input id="confirmPassword" placeholder="Confirme sua senha" />
            </div>
          </CardContent>
          <CardFooter>
            <Button>Criar nova conta</Button>
          </CardFooter>
        </Card>
      </TabsContent>
      </div>
    </Tabs>
  )
}


// export function Registro2() {
//   return (
//     <div>
//       <Head>
//         <title >Reservas: Registro</title>
//         <link rel="icon" href="/favicon.ico" />
//       </Head>
//       <div className="h-screen bg-gray-200 py-20 p-4 md:p-20 lg:p-32">
//     <div className="max-w-sm bg-white rounded-lg overflow-hidden shadow-lg mx-auto">
//         <div class="p-6">
//             <h2 className="text-2xl font-bold text-gray-800 mb-2">Sistema de Reservas</h2>
//             <p>Realize seu cadastro</p>
//             <form>
//                 <div className="mb-4">
//                     <label className="block text-gray-700 font-bold mb-2" for="username">
//             E-mail
//           </label>
//                     <input className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" id="username" type="text" placeholder="Digite seu e-mail"/>
//                 </div>
//                 <div class="mb-6">
//                     <label class="block text-gray-700 font-bold mb-2" for="password">
//             Senha
//           </label>
//                     <input class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" id="password" type="password" placeholder="Digite sua enha"/>
//                 </div>
//                 <div class="mb-6">
//                     <label class="block text-gray-700 font-bold mb-2" for="password">
//             Confirmação de senha
//           </label>
//                     <input class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" id="confirmPassword" type="password" placeholder="Confirme sua enha"/>
//                 </div>
//                 <div class="flex items-center justify-between">
//                     <button class="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline" type="button">
//             Entrar
//           </button>
//                     <a class="inline-block align-baseline font-bold text-sm text-blue-500 hover:text-blue-800" href="#">
//                         Esqueceu a senha?
//                     </a>
//                 </div>
//             </form>
//         </div>
//     </div>
//     </div>
//     </div>
//   );
// }
