import React from 'react';
import ReactDOM from 'react-dom';
import ArtistCollaborationList from './ArtistCollaborationList';

describe('ArtistCollaborationList', () => {
  it('ArtistCollaborationList Renders without crashing', () => {
    const div = document.createElement('div');
    ReactDOM.render(<ArtistCollaborationList />, div);
  });
});
