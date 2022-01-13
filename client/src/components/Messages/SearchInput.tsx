import { Header, Input } from 'semantic-ui-react'

export const SearchInput = () => {
  return (
    <Header floated="right">
      <Input
        icon="search"
        placeholder="Search Messages"
        size="mini"
        name="searchTerm"
      />
    </Header>
  )
}
