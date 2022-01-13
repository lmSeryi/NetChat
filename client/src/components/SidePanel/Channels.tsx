import { useEffect, useState } from 'react'
import { Button, Icon, Loader, Menu, Modal } from 'semantic-ui-react'
import { useForm } from '../../hooks/useForm'
import { IChannel } from '../../models/channelModel'
import { Channel } from './Channel'
import { ChannelForm } from './ChannelForm'
import { useAppDispatch, useAppSelector } from '../../hooks/useStore'
import { addNewChannel, loadChannel } from '../../store/actions/channelActions'
import { isLoading } from '../../store/reducers/channelReducer'

export const Channels: React.FC = () => {
  const dispatch = useAppDispatch()
  const { data, loading } = useAppSelector((state) => state.channels)

  const loadChannels = async () => {
    dispatch(isLoading())
    dispatch(loadChannel())
  }

  useEffect(() => {
    !data.length && loadChannels()
  }, [])

  const [modalOpen, setModalOpen] = useState(false)

  const { form, handleChange, reset } = useForm<IChannel>({
    name: '',
    description: '',
  })

  const handleOpen = () => setModalOpen(true)
  const handleClose = () => setModalOpen(false)
  const handleSubmit = () => {
    const channel = {
      name: form.name,
      description: form.description,
      id: undefined,
    }
    dispatch(addNewChannel(channel))
    reset()
    handleClose()
  }

  return (
    <>
      <Menu.Menu style={{ paddingBottom: '2em' }}>
        <Menu.Item>
          <span>
            <Icon name="exchange" /> Channels
          </span>{' '}
          ({data.length}){' '}
          {!loading ? (
            <Icon
              style={{ cursor: 'pointer' }}
              name={'add'}
              onClick={handleOpen}
            />
          ) : (
            <Loader size="tiny" inverted active style={{ left: '85%' }} />
          )}
        </Menu.Item>
        {data.length > 0 && data.map((c) => <Channel key={c.id} channel={c} />)}
      </Menu.Menu>
      <Modal open={modalOpen} basic>
        <Modal.Header>Add Channel</Modal.Header>
        <Modal.Content>
          <ChannelForm {...form} handleChange={handleChange} />
        </Modal.Content>
        <Modal.Actions>
          <Button color="green" basic inverted onClick={handleSubmit}>
            <Icon name="checkmark" /> Add
          </Button>
          <Button color="grey" onClick={handleClose} basic inverted>
            <Icon name="remove" />
            Cancel
          </Button>
        </Modal.Actions>
      </Modal>
    </>
  )
}

export default Channels
