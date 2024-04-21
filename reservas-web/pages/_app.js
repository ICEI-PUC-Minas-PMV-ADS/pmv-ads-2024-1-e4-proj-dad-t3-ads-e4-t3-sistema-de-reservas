import '../styles/global.css';
import Navbar from '/components/Navbar'
 
export default function MyApp({ Component, pageProps }) {
  return (
    <div>
 <Navbar user={{ userType: 'Condominios' }} />
      <Component {...pageProps} />
    </div>

    // </Layout>
  )
}

