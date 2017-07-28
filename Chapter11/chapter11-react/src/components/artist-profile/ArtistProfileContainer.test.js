import React from 'react';
import ReactDOM from 'react-dom';
import { shallow } from 'enzyme';
import renderer from 'react-test-renderer';
import ArtistProfileContainer from './ArtistProfileContainer';
import ArtistProfileBanner from './ArtistProfileBanner';
import ArtistProfilePicture from './ArtistProfilePicture';
import ArtistNameAndBio from './ArtistNameAndBio';
import ArtistCollaborationList from './ArtistCollaborationList';


describe('ArtistProfileContainer', () => {
  it('ArtistProfileContainer Renders without crashing', () => {
    const div = document.createElement('div');
    ReactDOM.render(<ArtistProfileContainer />, div);
  });

  it('ArtistProfileContainer should render Banner, Picture, CollaborationList and NameAndBio', () => {
    const wrapper = shallow(<ArtistProfileContainer />);
    expect(wrapper.contains([
      <ArtistProfilePicture />
    ])).toBe(true);

    expect(wrapper.contains([
      <ArtistProfileBanner />
    ])).toBe(true);

    expect(wrapper.contains([
      <ArtistNameAndBio />
    ])).toBe(true);

    expect(wrapper.contains([
      <ArtistCollaborationList />
    ])).toBe(true);
  });


  it('ArtistProfileContainer Matches Snapshot', () => {
    const component = renderer.create(<ArtistProfileContainer />);
    const tree = component.toJSON();
    expect(tree).toMatchSnapshot();
  });
});
