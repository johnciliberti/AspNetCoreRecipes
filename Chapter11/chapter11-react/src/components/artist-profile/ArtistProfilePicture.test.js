import React from 'react';
import ReactDOM from 'react-dom';
import ArtistProfilePicture from './ArtistProfilePicture';

describe('ArtistProfilePicture', () => {
  it('ArtistProfilePicture Renders without crashing', () => {
    const div = document.createElement('div');
    ReactDOM.render(<ArtistProfilePicture profileImage={'/images/profileSample.jpg'} />, div);
  });
});
