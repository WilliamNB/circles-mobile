using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject linePrefabB;
    public GameObject linePrefabG;
    public GameObject linePrefabP;
    public GameObject linePrefabR;
    public GameObject linePrefabM;
    public GameObject currentLine;

    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;
    public List<Vector2> tapPositions;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                switch (hit.transform.tag)
                {
                    case "circleB":
                        linePrefab = linePrefabB;
                        break;
                    case "circleG":
                        linePrefab = linePrefabG;
                        break;
                    case "circleP":
                        linePrefab = linePrefabP;
                        break;
                    case "circleR":
                        linePrefab = linePrefabR;
                        break;
                    case "circleM":
                        linePrefab = linePrefabM;
                        break;
                }

                CreateLine();
            }
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 tempPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(tempPos, tapPositions[tapPositions.Count - 1]) > .1f)
            {
                UpdateLine(tempPos);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            Destroy(currentLine);
            if (GameObject.Find("clicked"))
            {
                Destroy(GameObject.Find("clicked"));
            }
            Destroy(GameObject.Find("clicked"));
        }

    }

    void CreateLine()
    {

        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        tapPositions.Clear();
        tapPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        tapPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        lineRenderer.SetPosition(0, tapPositions[0]);
        lineRenderer.SetPosition(1, tapPositions[1]);
        lineRenderer.numCapVertices = 10;
        edgeCollider.points = tapPositions.ToArray();

    }

    void UpdateLine(Vector2 newTapPos)
    {
        if (currentLine != null)
        {
            tapPositions.Add(newTapPos);
            lineRenderer.positionCount++;
            lineRenderer.SetPosition(lineRenderer.positionCount - 1, newTapPos);
            edgeCollider.points = tapPositions.ToArray();
        }
    }
}
