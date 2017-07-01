import React from 'react';
import ReactDOM from 'react-dom';
import ArtistCollaborationListRow from './ArtistCollaborationListRow';

describe('ArtistCollaborationListRow', () => {
  it('ArtistCollaborationListRow Renders without crashing', () => {
    const div = document.createElement('div');
    ReactDOM.render(<ArtistCollaborationListRow />, div);
  });
});
