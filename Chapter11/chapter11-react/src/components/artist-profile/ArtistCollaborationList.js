import React from 'react';

const ArtistCollaborationList = () => (
  <table className="table table-striped">
    <thead>
      <tr>
        <th>
          Project Name
        </th>
        <th>
          Status
        </th>
        <th>
          Created
        </th>
        <th>
          Modified
        </th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>Project 1</td>
        <td>Recruiting / Idea Exchange</td>
        <td>12/28/2016</td>
        <td>1/2/2017</td>
      </tr>
      <tr>
        <td>Project 2</td>
        <td>Mixing</td>
        <td>12/28/2016</td>
        <td>1/2/2017</td>
      </tr>
    </tbody>
  </table>
);

export default ArtistCollaborationList;

