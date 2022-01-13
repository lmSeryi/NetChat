import { Grid } from 'semantic-ui-react'
import SidePanel from './components/SidePanel'
import ColorPanel from './components/ColorPanel'
import Messages from './components/Messages'
import MetaPanel from './components/MetaPanel'

import { Provider } from 'react-redux'
import store from './store'

import { Toaster } from 'react-hot-toast'

function App() {
  return (
    <Provider store={store}>
      <Toaster />
      <Grid columns="equal" className="app">
        <ColorPanel />
        <SidePanel />
        <Grid.Column style={{ marginLeft: 320 }}>
          <Messages />
        </Grid.Column>
        <Grid.Column width={4}>
          <MetaPanel />
        </Grid.Column>
      </Grid>
    </Provider>
  )
}

export default App
