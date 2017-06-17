import React from 'react';
import ReactDOM from 'react-dom';
import ArtistNameAndBio from './ArtistNameAndBio';

describe('ArtistNameAndBio', () => {
  it('ArtistNameAndBio Renders without crashing', () => {
    const div = document.createElement('div');
    ReactDOM.render(
      (<ArtistNameAndBio
        artistBio={'test'}
        artistName={{ firstName: 'firstName', lastName: 'lastName' }}
      />), div);
  });
});
