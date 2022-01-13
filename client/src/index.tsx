import { Suspense, lazy } from 'react'
import ReactDOM from 'react-dom'
import './index.css'
import './App.css'
import reportWebVitals from './reportWebVitals'
import { BrowserRouter, Routes, Route } from 'react-router-dom'

const App = lazy(() => import('./App'))
const Login = lazy(() => import('./components/Auth/Login'))
const Register = lazy(() => import('./components/Auth/Register'))

ReactDOM.render(
  <Suspense fallback="loading">
    <BrowserRouter>
      <Routes>
        <Route path="auth">
          <Route path="login" element={<Login />} />
          <Route path="register" element={<Register />} />
        </Route>
        <Route path="/" element={<App />} />
        <Route path="*" element={<Login />} />
      </Routes>
    </BrowserRouter>
  </Suspense>,
  document.getElementById('root'),
)

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals()
