import { createFileRoute } from "@tanstack/react-router";
import { Button } from "@/components/ui/button";
import { Input } from "@/components/ui/input";
import { useState } from "react";

export const Route = createFileRoute("/organizations/$orgId/pages/$pageId")({
  component: PageEditor,
});

function PageEditor() {
  const { orgId, pageId } = Route.useParams();
  const [title, setTitle] = useState("Untitled Page");
  const [content, setContent] = useState("");

  // TODO: Ticket #11 - Page Editor Interface
  // Implement page fetching and saving
  // const { data: page, isLoading } = usePage(pageId);
  // const { mutate: updatePage } = useUpdatePage();

  const handleSave = () => {
    // TODO: Ticket #11 - Page Editor Interface
    // Implement page saving logic
    console.log("Saving page:", { pageId, title, content });
  };

  return (
    <div className="container mx-auto p-6 max-w-4xl">
      <div className="mb-6">
        <Input
          value={title}
          onChange={(e) => setTitle(e.target.value)}
          className="text-2xl font-bold border-none shadow-none p-0 mb-2"
          placeholder="Untitled Page"
        />
        <div className="flex gap-2">
          <Button onClick={handleSave} size="sm">
            Save
          </Button>
          <Button variant="outline" size="sm">
            Share
          </Button>
        </div>
      </div>

      <div className="min-h-[500px] border rounded-lg p-6">
        <textarea
          value={content}
          onChange={(e) => setContent(e.target.value)}
          className="w-full h-full border-none outline-none resize-none"
          placeholder="Start writing..."
        />
      </div>

      {/* TODO: Ticket #12 - Block Editor Implementation
          Replace this simple textarea with Tiptap editor
          Add block types (paragraph, heading, todo, etc.)
          Add block creation and editing functionality
          Add block positioning and reordering
      */}
    </div>
  );
}

/* 
TODO: Ticket #11 - Page Editor Interface
- This file has the basic page editor structure
- Implement page fetching from API
- Add page saving functionality
- Add page title editing
- Add page settings and metadata
- Test page navigation and editing

TODO: Ticket #12 - Block Editor Implementation
- Replace simple textarea with Tiptap editor
- Add different block types (paragraph, heading, todo, etc.)
- Implement block creation and editing
- Add block positioning and reordering
- Add real-time collaboration features
*/
