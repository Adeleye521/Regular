import React from 'react';

const MyComponent = ({ title = 'Hello React', message = 'Edit this component to get started.' }) => {
  return (
    <section style={styles.section}>
      <h1 style={styles.heading}>{title}</h1>
      <p style={styles.text}>{message}</p>
    </section>
  );
};

const styles = {
  section: {
    padding: '1.5rem',
    borderRadius: '12px',
    backgroundColor: '#f5f7fb',
    border: '1px solid #d9e2ec',
    fontFamily: 'Inter, -apple-system, BlinkMacSystemFont, "Segoe UI", sans-serif',
  },
  heading: {
    margin: 0,
    color: '#102a43',
    fontSize: '1.75rem',
    lineHeight: 1.2,
  },
  text: {
    margin: '0.5rem 0 0',
    color: '#243b53',
    fontSize: '1rem',
    lineHeight: 1.6,
  },
};

export default MyComponent;
